using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MonetarWin
{
    public partial class ControlCurrency : UserControl
    {        
        public ControlCurrency()
        {
            InitializeComponent();            
        }

        public ControlCurrency(Currency currency)
        {
            TheCurrency = currency;
        }

        private Currency _theCurrency;
        public Currency TheCurrency
        {
            get { return _theCurrency; }
            set
            {
                _theCurrency = value;
                currencyDenomAmountBindingSource.DataSource = new BindingList<CurrencyDenomAmount>(_theCurrency.DenomAmounts);
                currencyBindingSource.DataSource = _theCurrency;                
            }
        }

        private void UCCurrency_Load(object sender, EventArgs e)
        {
            /*
            gridAmounts.Height = gridAmounts.GetRowDisplayRectangle(gridAmounts.RowCount - 1, true).Bottom +
               gridAmounts.GetRowDisplayRectangle(gridAmounts.RowCount - 1, false).Height;
               */
        }

        private void gridAmounts_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            long tmp;
            e.Cancel = e.ColumnIndex == 0 && (!long.TryParse(e.FormattedValue.ToString(), NumberStyles.Number, CultureInfo.CurrentCulture, out tmp) || tmp < 0);            
        }
    }
}
