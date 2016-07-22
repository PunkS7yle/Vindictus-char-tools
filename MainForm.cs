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
        public List<string> SuffixNames = File.ReadLines(SuffixList).ToList();
        public List<string> PrefixNames = File.ReadLines(PrefixList).ToList();
        private readonly Character Char = new Character();  
        private readonly Dictionary<string, string> prefixes = new Dictionary<string, string>();
        private readonly Dictionary<string, string> suffixes = new Dictionary<string, string>();

        public MainForm()
        {
            EstablishConnection();
            InitializeComponent();
            LoadScrolls();
            searchComboBox.SelectedIndex = 1;
            classComboBox.Items.AddRange(Classes);                   
        }

        private void LoadScrolls()
        {
            foreach (var line in PrefixNames)
            {
                var tmp = line.Split('=');
                prefixes.Add(tmp[0], tmp[1]);
            }
            foreach (var line in SuffixNames)
            {
                var tmp = line.Split('=');
                suffixes.Add(tmp[0], tmp[1]);
            }
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
            itemListView.ClearObjects();   
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
                itemListView.DisableObject(e.Model);
                HandleItem(e.RowIndex,e.SubItem.Text,(Item)e.Model);              
                itemListView.RefreshObject(e.Model);

            };
        }

        private void HandleItem(int rowIndex, string value, Item model)
        {
            if (value == "Edit")
            {
                var atr = new ItemAttribute();
                foreach (var row in dh.GetAttributes(model.Id)) 
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
                    else if (row.Attribute== "PREFIX")
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
                foreach (var row in dh.GetItemColor(model.Id))
                {
                    atr.Color1 = row.Color1;
                    atr.Color2 = row.Color2;
                    atr.Color3 = row.Color3;
                    atr.ReducedDurability = row.ReducedDurability;
                    atr.ExtraDurability = row.MaxDurabilityBonus;
                }

                  using (var form = new EditItemForm(atr,prefixes,suffixes,model,dh))
                  {
                      var result =form.ShowDialog();
                      if (result == DialogResult.OK)
                      {
                          itemListView.EnableObject(model);
                      }
                  }
            }
            else if (value == "Delete")
            {
                
                DialogResult deleteResult = MessageBox.Show( $"\tAre you sure you want to delete the item : \n Name : {model.Name} \n Slot : {model.SlotId}","WARNING",MessageBoxButtons.YesNo);
                if (deleteResult == DialogResult.Yes)
                {
                    dh.DeleteItem(model.Id);
                   
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
