using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Calstructure.ViewModels
{
    public class CircularViewModel : INotifyPropertyChanged
    {
        private double _q;
        private double _r;
        private double _prResult;

        public double Q
        {
            get => _q;
            set
            {
                _q = value;
                OnPropertyChanged();
                CalculatePr();
            }
        }

        public double R
        {
            get => _r;
            set
            {
                _r = value;
                OnPropertyChanged();
                CalculatePr();
            }
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public double PrResult
        {
            get => _prResult;
            set
            {
                _prResult = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void CalculatePr()
        {
            PrResult = _q * _r;
        }
    }
}
