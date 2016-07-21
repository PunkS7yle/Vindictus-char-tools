using MetroFramework.Forms;
using System.Collections.Generic;
using System.Windows.Forms;

using static Vindictus_Tools.Enums;
using static System.Convert;

namespace Vindictus_Tools
{
    

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

            //TODO : Implement the other attribs and colors



        }

        private void DoneEditButtonClick(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
