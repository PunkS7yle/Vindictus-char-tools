namespace Vindictus_Tools
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;

    using MetroFramework.Forms;
    using static Enums;
    using static System.Convert;

    public partial class MainForm : MetroForm
    {
        private readonly DatabaseHandler dh = new DatabaseHandler("localhost","sa","","heroes");

        private readonly List<string> itemNames = File.ReadLines(ItemList).ToList();

        public readonly Character Char = new Character();

        public MainForm()
        {
            InitializeComponent();
            classComboBox.Items.AddRange(Classes);
            
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


        void ParseItems()
        {
            itemGrid.Rows.Clear();
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
                itemGrid.Rows.Add(tempItem.Name,tempItem.Class,tempItem.Id,tempItem.Amount,tempItem.SlotId,tempItem.Tradeable,tempItem.Date);

            }
        }

        private void MetroButton1Click(object sender, EventArgs e)
        {
            dh.UpdateCharData(nameBox.Text,ToInt32(levelBox.Text),ToInt64(expBox.Text),ToInt32(apBox.Text),classComboBox.SelectedIndex,pathComboBox.SelectedIndex,ToInt32(pathLevelBox.Text)
                ,craftTypeBox.Text,craftComboBox.SelectedIndex,ToInt32(craftExpBox.Text),Char.CharacterId);
            MessageBox.Show("Char Data Updated");
        }
    }
}
