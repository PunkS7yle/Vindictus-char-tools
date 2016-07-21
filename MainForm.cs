using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;
using Newtonsoft.Json;
using BrightIdeasSoftware;

using static Vindictus_Tools.Enums;
using static System.Convert;

namespace Vindictus_Tools
{
    public partial class MainForm : MetroForm
    {
        private DatabaseHandler dh;
        private readonly List<string> itemNames = File.ReadLines(ItemList).ToList();
        public readonly Character Char = new Character();

        public MainForm()
        {
            EstablishConnection();
            InitializeComponent();
            
            classComboBox.Items.AddRange(Classes);
           // var form = new EditItemForm();
           // form.ShowDialog();

        }

        private void EstablishConnection()
        {    
           var conObj = JsonConvert.DeserializeObject<Connection>(File.ReadAllText("connInfo.json"));
           dh = new DatabaseHandler(conObj.Ip, conObj.User, conObj.Pass, "heroes");  
        }

        private void SearchButtonClick(object sender, EventArgs e)
        {
            var searchValue=searchBox.Text;

            if (searchComboBox.SelectedIndex == 1)
            {
                searchValue = $"'{searchBox.Text}'";
            }

            foreach (var row in dh.GetCharacterData(searchComboBox.SelectedItem.ToString(),searchValue))
            {
                Char.Name = row.name;
                Char.Level = row.level;
                Char.Exp = row.exp;
                Char.CharacterId = row.id;
                Char.Class = row.Class;
                Char.Ap = row.ap;
            }

            nameBox.Text = Char.Name;
            levelBox.Text = Char.Level.ToString();
            expBox.Text = Char.Exp.ToString();
            apBox.Text = Char.Ap.ToString();
            classComboBox.SelectedIndex = Char.Class;
            cidBox.Text = Char.CharacterId.ToString();

            foreach (var row in dh.GetCharacterPath(Char.CharacterId))
            {
                Char.Path = row.vocationclass;
                Char.PathLevel = row.vocationlevel;
            }

            pathComboBox.SelectedIndex = Char.Path;
            pathLevelBox.Text = Char.PathLevel.ToString();

            foreach (var row in dh.GetCharacterCrafting(Char.CharacterId))
            {
                Char.CraftType = row.manufacturelid;
                Char.CraftGrade = row.grade;
                Char.CraftExp = row.experiencepoint;
            }

            craftTypeBox.Text = Char.CraftType;
            craftComboBox.SelectedIndex = Char.CraftGrade;
            craftExpBox.Text = Char.CraftExp.ToString();


            foreach (var row in dh.GetCharacterGuild(Char.CharacterId))
            {
                Char.Guild = row.guildid;
            }

            guildBox.Text = Char.Guild;

           
           ParseItems();

        }

        private void ParseItems()
        {
            //itemGrid.Rows.Clear();
            foreach (var row in dh.GetItems(Char.CharacterId))
            {
                Item tempItem = new Item();
                tempItem.Class = row.ItemClass;
                tempItem.Amount = row.Count;
                if (row.ExpireDateTime != null)
                {
                    tempItem.Date = row.ExpireDateTime;
                }
                tempItem.SlotId = row.Slot;
                tempItem.Tradeable = row.Tradable;
                tempItem.Id = row.ID;
                tempItem.Name = itemNames.FirstOrDefault(name => name.ToLower().Contains(tempItem.Class.ToLower()))?.Split('=')[1];
                tempItem.Edit = "Edit";
                tempItem.Delete = "Delete";
                itemListView.AddObject(tempItem);
            }

            itemListView.ButtonClick += delegate (object sender, CellClickEventArgs e)
            {
                MessageBox.Show($"Button clicked: ({e.RowIndex}, {e.SubItem}, {e.Model})");
                EditItem(e.RowIndex,e.SubItem.Text);              
                itemListView.RefreshObject(e.Model);

            };
        }

        private void EditItem(int rowIndex, string value)
        {
            if (value == "Edit")
            {
                var atr = new ItemAttribute();
                foreach (var row in dh.GetAttributes(ToInt64(itemListView.GetSubItem(rowIndex, 3).Text))) // 3 = index of itemid column
                {
                    if (row.Attribute == "ENHANCE")
                    {
                        atr.Enhance = row.Value;
                    }
                    else if (row.Attribute == "COMBINATION")
                    {
                        atr.Combination.PartClasses = row.Value;
                    }
                    else if (row.Attribute == "QUALITY")
                    {
                        atr.Quality = row.Arg;
                        atr.CraftedBy = row.Value;
                    }
                    else if (row.Attribute == "SUFFIX")
                    {
                        atr.Suffix = row.Value;
                    }
                    else if (row.Attribute == "PREFIX")
                    {
                        atr.Prefix = row.Value;
                    }
                    else if (row.Attribute == "PS_0")
                    {
                        atr.Combination.Part1 = row.Value;
                        atr.Combination.Skill = row.Arg2;
                    }
                    else if (row.Attribute == "PS_1")
                    {
                        atr.Combination.Part2 = row.Value;
                    }
                    else if (row.Attribute == "PS_2")
                    {
                        atr.Combination.Part3 = row.Value;
                    }
                    else if (row.Attribute == "PS_3")
                    {
                        atr.Combination.Part4 = row.Value;
                    }
                    else if (row.Attribute == "PS_4")
                    {
                        atr.Combination.Part5 = row.Value;
                    }

                }

                  using (var form = new EditItemForm(atr))
                  {
                      form.ShowDialog();
                  }
            }
        }

        private void UpdateDataButtonClick(object sender, EventArgs e)
        {
            dh.UpdateCharData(nameBox.Text,ToInt32(levelBox.Text),ToInt64(expBox.Text),ToInt32(apBox.Text),classComboBox.SelectedIndex,pathComboBox.SelectedIndex,ToInt32(pathLevelBox.Text)
            ,craftTypeBox.Text,craftComboBox.SelectedIndex,ToInt32(craftExpBox.Text),Char.CharacterId);
            MessageBox.Show("Char Data Updated");
        }

        private void SettingsButtonClick(object sender, EventArgs e)
        {
            using (var form = new ConfigForm())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Connection conInfo = new Connection
                                             {
                                                 Ip = ConfigForm.Ip,
                                                 User = ConfigForm.User,
                                                 Pass = ConfigForm.Pass
                                             };
                    var configOutput = JsonConvert.SerializeObject(conInfo);
                    File.WriteAllText("connInfo.json",configOutput);
                }
            }
            EstablishConnection();
        }
    }
}
