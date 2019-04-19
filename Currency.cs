using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace MonetarWin
{
    [Serializable]
    public class Currency: System.ComponentModel.INotifyPropertyChanged
    {        
        public string Name { get; set; }
        public string Description { get; set; }
        private CurrencyDenomAmount[] _denomAmounts;
        public CurrencyDenomAmount[] DenomAmounts
        {
            get { return _denomAmounts; }
            set
            {
                _denomAmounts = value;
                
                foreach (CurrencyDenomAmount ca in _denomAmounts)
                {                    
                    ca.PropertyChanged += DenomAmountsChanged;
                }                

                OnPropertyChanged("DenomAmounts");
            }
        }


        protected virtual void DenomAmountsChanged(object sender, PropertyChangedEventArgs args)
        {
            OnPropertyChanged("DenomAmounts");
        }

        public Currency()
        {
            
        }

        public Currency(string name, CurrencyDenomAmount[] denomAmounts)
        {
            this.Name = name;
            this.DenomAmounts = denomAmounts;            
        }

        [XmlIgnoreAttribute]
        public decimal SumCurrent => this.DenomAmounts.Sum(ct => ct.TotalValueDenom);
        private decimal _sumPrev;
        public decimal SumPrev
        {
            get { return _sumPrev; }
            set
            {
                _sumPrev = value;
                OnPropertyChanged("Remaining");
            }
        }

        [XmlIgnoreAttribute]
        public decimal Remaining => SumCurrent - SumPrev;

        

        public override string ToString()
        {
            return $"{SumCurrent} {Name}";
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }


    [Serializable]
    public class CurrencyDenomAmount : System.ComponentModel.INotifyPropertyChanged
    {                
        public string DenomName { get; set; }
        public decimal DenomValue { get; set; }

        private long _pieceCount;
        public long PieceCount
        {
            get { return _pieceCount; }
            set
            {
                _pieceCount = value;
                OnPropertyChanged();
                OnPropertyChanged("TotalValueDenom");                
            }
        }

        [XmlIgnoreAttribute]
        public decimal TotalValueDenom => PieceCount * DenomValue;

        public CurrencyDenomAmount()
        {
            
        }

        public CurrencyDenomAmount(string name, decimal value, long count = 0)
        {            
            this.DenomName = name;
            this.DenomValue = value;
            this.PieceCount = count;
        }

        public override string ToString()
        {
            return $"{PieceCount} x {DenomName} = {PieceCount * DenomValue}";
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

}
