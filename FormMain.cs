using System;
using System.Configuration;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using MonetarWin.Properties;

namespace MonetarWin
{
    public partial class FormMain : Form
    {        
        private Currency[] theCurrencies;

        private static readonly string AppName = Application.ProductName;       
        private static readonly string persistanceFolder = Path.Combine(Environment.GetFolderPath(System.Environment.SpecialFolder.CommonApplicationData), AppName);        
        private static readonly string logFilePath = Path.Combine(persistanceFolder, AppName + ".log");        

        public void InitData()
        {
            try
            {                
                theCurrencies = LoadCurrencies();
                if (theCurrencies == null)
                {
                    Settings.Default.Reset();
                    theCurrencies = LoadCurrencies();
                }

                DisplayCurrencies();

                if (!Directory.Exists(persistanceFolder))
                    Directory.CreateDirectory(persistanceFolder);
            }
            catch (Exception e)
            {
                LogEx(e);
                MessageBox.Show("Eroare: " + e.Message, AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        void InitUi()
        {
            this.Text = $"{Application.ProductName} - {Settings.Default.BranchName}";
            toolStripStatusLabel1.Text = Settings.Default.WarnMsg;
        }

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            bool signOK = false;
            if (!CheckConfigSign())
            {
                FormConfig frmConfig = new FormConfig();
                if (frmConfig.ShowDialog(this) == DialogResult.OK)
                {
                    SignConfig();
                    signOK = true;
                }
            }
            else
            {
                signOK = true;
            }

            if (!signOK)
            {
                MessageBox.Show("Fișierul de configurare nu corespunde. Programul se va închide.",
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                InitData();
                InitUi();
            }
        }

        private void DisplayCurrencies()
        {
            panelFlow.Controls.Clear();
            foreach (Currency c in theCurrencies)
            {
                ControlCurrency ctrl = new ControlCurrency();
                ctrl.TheCurrency = c;
                panelFlow.Controls.Add(ctrl);
            }
        }

        void SaveCurrencies(Currency[] c)
        {                                   
            var document = new XmlDocument();
            var navigator = document.CreateNavigator();

            using (var writer = navigator.AppendChild())
            {
                var serializer = new XmlSerializer(typeof(Currency[]));
                serializer.Serialize(writer, c);
            }

            Settings.Default.Currency = document;
            Settings.Default.Save();        
        }

        Currency[] LoadCurrencies()
        {
            Currency[] c = null;            

            var document = Settings.Default.Currency;
            if (document != null)
            {
                var navigator = document.CreateNavigator();

                using (var reader = navigator.ReadSubtree())
                {
                    var deserializer = new XmlSerializer(typeof(Currency[]));
                    c = (Currency[])deserializer.Deserialize(reader);
                }
            }            

            return c;
        }

        public static void LogEx(Exception e)
        {            
            File.AppendAllText(logFilePath, $"{Environment.NewLine}{DateTime.Now} - {e.Message}{Environment.NewLine}{e.StackTrace}");
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {            
            SaveCurrencies(theCurrencies);            
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveCurrencies(theCurrencies);
            MessageBox.Show("Salvat", AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReport frmRep = new FormReport();
            frmRep.TheCurrencies = theCurrencies;
            frmRep.BranchName = $"{Settings.Default.BranchName} {Settings.Default.BranchAddres}";
            frmRep.ShowDialog(this);
        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{Application.ProductName} v{Application.ProductVersion}, {Application.CompanyName} {Environment.NewLine}Tel: 0740079528, Email: george.chirtoaca@gmail.com.", 
                AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);            
        }

        private void configToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConfig frmConfig = new FormConfig();            
            frmConfig.ShowDialog(this);

            InitUi();           
        }

        public void SignConfig()
        {
            Configuration cfg = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            XmlDocument cfgXml = new XmlDocument();
            cfgXml.PreserveWhitespace = true;
            cfgXml.Load(cfg.FilePath);
            XmlSign.SignXml(cfgXml);
            cfgXml.Save(cfg.FilePath);
        }

        private bool CheckConfigSign()
        {
            Configuration cfg = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);            
            XmlDocument cfgXml = new XmlDocument();
            cfgXml.PreserveWhitespace = true;
            cfgXml.Load(cfg.FilePath);
            return XmlSign.VerifyXml(cfgXml);
        }
    }
       
}