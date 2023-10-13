using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Calstructure.ViewModels
{
    public class OutofPlaneStrengthViewModel : INotifyPropertyChanged
    {
        private double _e;
        private double _lo;
        private double _ko;
        private double _ldb;
        private double _peo;

        public double E
        {
            get => _e;
            set
            {
                _e = value;
                OnPropertyChanged();
                CalculatePeo();
            }
        }

        public double Lo
        {
            get => _lo;
            set
            {
                _lo = value;
                OnPropertyChanged();
                CalculatePeo();
            }
        }

        public double Ko
        {
            get => _ko;
            set
            {
                _ko = value;
                OnPropertyChanged();
                CalculatePeo();
            }
        }

        public double Ldb
        {
            get => _ldb;
            set
            {
                _ldb = value;
                OnPropertyChanged();
                CalculatePeo();
            }
        }

        public double Peo
        {
            get => _peo;
            set
            {
                _peo = value;
                OnPropertyChanged();
            }
        }

        private void OnPropertyChanged()
        {
            throw new NotImplementedException();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void CalculatePeo()
        {
            Peo = (Math.PI * Math.PI * E * Lo) / (Math.Pow(Ko * Ldb, 2));
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
