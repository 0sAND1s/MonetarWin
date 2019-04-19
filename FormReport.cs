using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace MonetarWin
{
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }

        private Currency[] _theCurrencies;
        public Currency[] TheCurrencies
        {
            get { return _theCurrencies; }
            set
            {
                _theCurrencies = value;                
                CurrencyBindingSource.DataSource = _theCurrencies;                
            }
        }

        public string BranchName { get; set; }

        private void FormReport_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.SubreportProcessing += LocalReport_SubreportProcessing;            
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("BranchName", BranchName));
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = ZoomMode.Percent;
            this.reportViewer1.ZoomPercent = 100;
            this.reportViewer1.LocalReport.DisplayName = $"Monetar_{DateTime.Now.ToShortDateString()}_{DateTime.Now.ToShortTimeString()}";

            this.reportViewer1.RefreshReport();            
        }

        private void LocalReport_SubreportProcessing(object sender, Microsoft.Reporting.WinForms.SubreportProcessingEventArgs e)
        {            
            string curName = e.Parameters["CurName"].Values.First();
            Currency subSrc = _theCurrencies.FirstOrDefault(cur => cur.Name == curName);
            if (subSrc != null)
                e.DataSources.Add(new ReportDataSource("dsCurency", subSrc.DenomAmounts));
        }
    }
}
