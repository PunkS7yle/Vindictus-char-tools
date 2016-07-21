using MetroFramework.Forms;

using static Vindictus_Tools.Enums;
using static System.Convert;

namespace Vindictus_Tools
{

    public partial class EditItemForm : MetroForm
    {
        public EditItemForm(ItemAttribute itemAttribute)
        {
            InitializeComponent();

            enhanceComboBox.SelectedIndex = ToInt32(itemAttribute.Enhance);
            qualityComboBox.SelectedIndex = itemAttribute.Quality-1;
           //TODO : Implement the other attribs

        }


    }
}
