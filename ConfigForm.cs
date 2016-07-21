using System.Windows.Forms;
using MetroFramework.Forms;
using System.IO;
using Newtonsoft.Json;

using static Vindictus_Tools.Enums;

namespace Vindictus_Tools
{
    

    public partial class ConfigForm : MetroForm
    {
        public static string Ip { get; private set; }

        public static string User { get; private set; }

        public static string Pass { get; private set; }

        public ConfigForm()
        {
            InitializeComponent();
            var conObj = JsonConvert.DeserializeObject<Connection>(File.ReadAllText("ConnInfo.json"));
            ipBox.Text = conObj.Ip;
            userBox.Text = conObj.User;
            passBox.Text = conObj.Pass;
        }

        private void CloseFormButtonClick(object sender, System.EventArgs e)
        {
            Ip = ipBox.Text;
            User = userBox.Text;
            Pass = passBox.Text;
            DialogResult = DialogResult.OK;
            Close();
        }


    }
}
