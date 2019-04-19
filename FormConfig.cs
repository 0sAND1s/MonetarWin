using System;
using System.Windows.Forms;
using MonetarWin.Properties;
using System.Configuration;
using System.Text;

namespace MonetarWin
{
    public partial class FormConfig : Form
    {        
        public FormConfig()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {            
            Settings.Default.BranchName = txtBranchName.Text;
            Settings.Default.BranchAddres = txtBranchAddress.Text;
            Settings.Default.WarnMsg = txtWarnMsg.Text;
            Settings.Default.Save();            

            DialogResult = DialogResult.OK;
            this.Close();         
        }

        private void FormConfig_Load(object sender, EventArgs e)
        {
            txtBranchName.Text = Settings.Default.BranchName;
            txtBranchAddress.Text = Settings.Default.BranchAddres;
            txtWarnMsg.Text = Settings.Default.WarnMsg;
        }

        private void btnResetConfig_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmați resetarea configurației la cea inițială?", "Monetar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                Settings.Default.Reset();
                ((FormMain)Owner).InitData();
            }
        }

        private void btnUnlockConfig_Click(object sender, EventArgs e)
        {            
            grpConfig.Enabled = (txtPasswordUnlock.Text == Encoding.ASCII.GetString(Convert.FromBase64String("MDc0MDA3OTUyOA==")));
        }
    }
}
