using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Vindictus_Tools
{  
   public partial class ColorPickForm : MetroForm
    {
        public Color ItemColor { get; set; }

        public ColorPickForm()
        {
            InitializeComponent();        
        }

        private void MetroButton1Click(object sender, System.EventArgs e)
        {
            ItemColor = colorEditorManager1.Color;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
