using MetroFramework.Forms;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

using static Vindictus_Tools.Enums;
using static System.Convert;

namespace Vindictus_Tools
{
    using System.IO;
    using System.Linq;

    public partial class EditItemForm : MetroForm
    {
        private long Id {  get;  }
        private DatabaseHandler Dh { get;  }
        private string PrefixClass { get; set; }
        private string SuffixClass { get; set; }

        Color color1, color2, color3 ;

        private Dictionary<string, string> sD,pD;

        public EditItemForm(ItemAttribute itemAttribute, Dictionary<string,string> prefixDictionary, Dictionary<string,string> suffixDictionary, Item model, DatabaseHandler dh )
        {
            Id = model.Id;
            Dh = dh;
            sD = suffixDictionary;
            pD = prefixDictionary;

            InitializeComponent();
            foreach (var value in prefixDictionary.Values)
            {
                prefixComboBox.Items.Add(value);
            }
            foreach (var value in suffixDictionary.Values)
            {
                suffixComboBox.Items.Add(value);
            }

            enhanceComboBox.SelectedIndex = ToInt32(itemAttribute.Enhance);
            qualityComboBox.SelectedIndex = itemAttribute.Quality-1;
            itemClassBox.Text = model.Class;

            if (itemAttribute.Prefix == null)
            {
                prefixComboBox.SelectedIndex = 0;

            }
            else
            {
                prefixComboBox.SelectedItem = pD[itemAttribute.Prefix];
                PrefixClass = itemAttribute.Prefix;
            }
            if (itemAttribute.Suffix == null)
            {
                suffixComboBox.SelectedIndex = 0;
            }
            else
            {
                suffixComboBox.SelectedItem = sD[itemAttribute.Suffix];
                SuffixClass = itemAttribute.Suffix;
            }
            color1 = GetColor(itemAttribute.Color1);
            color2 = GetColor(itemAttribute.Color2);
            color3 = GetColor(itemAttribute.Color3);
            
            color1Box.Text = $"{color1.R},{color1.G},{color1.B}";
            color1Picture.BackColor = color1;

            color2Box.Text = $"{color2.R},{color2.G},{color2.B}";
            color2Picture.BackColor = color2;

            color3Box.Text = $"{color3.R},{color3.G},{color3.B}";
            color3Picture.BackColor = color3;

            combiClassesBox.Text = itemAttribute.Combination.PartClasses;
            part1Box.Text = itemAttribute.Combination.Part1;
            part2Box.Text = itemAttribute.Combination.Part2;
            part3Box.Text = itemAttribute.Combination.Part3;
            part4Box.Text = itemAttribute.Combination.Part4;
            part5Box.Text = itemAttribute.Combination.Part5;
            combiSkillBox.Text = itemAttribute.Combination.Skill.ToString(); //TODO implement skill picker


            //TODO : Item expiration



        }

        private Color GetColor(int color)
        {
            Color tmp = Color.FromArgb(color);
            return Color.FromArgb(255, tmp.R, tmp.G, tmp.B);
        }

        private static int RgbToInt(Color color)
        {
            return Color.FromArgb(0, color.R, color.G, color.B).ToArgb();
            
        }

        private void UpdateAttributes()
        {
            Dh.UpdateItemAttributes(
                Id,
                enhanceComboBox.SelectedIndex.ToString(),
                qualityComboBox.SelectedIndex+1,
                PrefixClass,
                SuffixClass,
                "",
                itemClassBox.Text,
                //TODO craftedby, itempartnr
                RgbToInt(color1),
                RgbToInt(color2),
                RgbToInt(color3),
                0,0,
                combiClassesBox.Text,
                part1Box.Text,
                part2Box.Text,
                part3Box.Text,
                part4Box.Text,
                part5Box.Text,
                ToInt32(combiSkillBox.Text)
                );
        }

        private void DoneEditButtonClick(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        #region events
        private void Color1PictureDoubleClick(object sender, System.EventArgs e)
        {
            using (var form = new ColorPickForm())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    color1Box.Text = $"{form.ItemColor.R},{form.ItemColor.G},{form.ItemColor.B}";
                    color1Picture.BackColor = GetColor(form.ItemColor.ToArgb());
                    color1 = form.ItemColor;
                }
            }
        }

        private void Color2PictureDoubleClick(object sender, System.EventArgs e)
        {
            using (var form = new ColorPickForm())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    color2Box.Text = $"{form.ItemColor.R},{form.ItemColor.G},{form.ItemColor.B}";
                    color2Picture.BackColor = GetColor(form.ItemColor.ToArgb());
                    color2 = form.ItemColor;
                }
            }
        }

        private void Color3PictureDoubleClick(object sender, System.EventArgs e)
        {
            using (var form = new ColorPickForm())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    color3Box.Text = $"{form.ItemColor.R},{form.ItemColor.G},{form.ItemColor.B}";
                    color3Picture.BackColor = GetColor(form.ItemColor.ToArgb());
                    color3 = form.ItemColor;
                }
            }
        }
      

        private void Color1BoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var tmp = color1Box.Text.Split(',');

                color1Picture.BackColor = Color.FromArgb(255, ToByte(tmp[0]), ToByte(tmp[1]), ToByte(tmp[2]));
                color1 = color1Picture.BackColor;
            }
        }

        private void SaveButtonClick(object sender, System.EventArgs e)
        {
            UpdateAttributes();
            MessageBox.Show("Item info updated !");
        }

        private void PrefixComboBoxSelectedIndexChanged(object sender, System.EventArgs e)
        {
            PrefixClass = pD.FirstOrDefault(x => x.Value == prefixComboBox.Text).Key;
        }

        private void SuffixComboBoxSelectedIndexChanged(object sender, System.EventArgs e)
        {
            SuffixClass = sD.FirstOrDefault(x => x.Value == suffixComboBox.Text).Key;
        }

        private void Color2BoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var tmp = color2Box.Text.Split(',');

                color2Picture.BackColor = Color.FromArgb(255, ToByte(tmp[0]), ToByte(tmp[1]), ToByte(tmp[2]));
                color2 = color1Picture.BackColor;
            }
        }

        private void Color3BoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var tmp = color3Box.Text.Split(',');

                color3Picture.BackColor = Color.FromArgb(255, ToByte(tmp[0]), ToByte(tmp[1]), ToByte(tmp[2]));
                color3 = color1Picture.BackColor;
            }
        }
        #endregion
    }
}
