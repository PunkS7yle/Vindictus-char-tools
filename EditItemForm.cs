using MetroFramework.Forms;
using System.Collections.Generic;
using System.Windows.Forms;

using static Vindictus_Tools.Enums;
using static System.Convert;

namespace Vindictus_Tools
{
    using System.Drawing;

    public partial class EditItemForm : MetroForm
    {
        

        public EditItemForm(ItemAttribute itemAttribute, Dictionary<string,string> prefixDictionary, Dictionary<string,string> suffixDictionary, Item model )
        {
            

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
                prefixComboBox.SelectedItem = prefixDictionary[itemAttribute.Prefix];
            }
            if (itemAttribute.Suffix == null)
            {
                suffixComboBox.SelectedIndex = 0;
            }
            else
            {
                suffixComboBox.SelectedItem = suffixDictionary[itemAttribute.Suffix];
            }
            var color1 = GetColor(itemAttribute.Color1);
            var color2 = GetColor(itemAttribute.Color2);
            var color3 = GetColor(itemAttribute.Color3);
            
            color1Box.Text = $"{color1.R},{color1.G},{color1.B}";
            color1Picture.BackColor = color1;

            color2Box.Text = $"{color2.R},{color2.G},{color2.B}";
            color2Picture.BackColor = color2;

            color3Box.Text = $"{color3.R},{color3.G},{color3.B}";
            color3Picture.BackColor = color3;



            //TODO : Implement the other attribs and colors



        }

        private Color GetColor(int color)
        {
            Color tmp = Color.FromArgb(color);
            return Color.FromArgb(255, tmp.R, tmp.G, tmp.B);
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
                }
            }
        }
      

        private void Color1BoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var tmp = color1Box.Text.Split(',');

                color1Picture.BackColor = Color.FromArgb(255, ToByte(tmp[0]), ToByte(tmp[1]), ToByte(tmp[2]));
            }
        }

        private void Color2BoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var tmp = color2Box.Text.Split(',');

                color2Picture.BackColor = Color.FromArgb(255, ToByte(tmp[0]), ToByte(tmp[1]), ToByte(tmp[2]));
            }
        }

        private void Color3BoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var tmp = color3Box.Text.Split(',');

                color3Picture.BackColor = Color.FromArgb(255, ToByte(tmp[0]), ToByte(tmp[1]), ToByte(tmp[2]));
            }
        }
        #endregion
    }
}
