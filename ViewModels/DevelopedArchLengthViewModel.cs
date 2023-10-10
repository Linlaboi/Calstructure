using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Calstructure.ViewModels
{
    public class DevelopedArchLengthViewModel : INotifyPropertyChanged
    {
        private double _r;
        private double _theta;
        private double _ldResult;

        public event PropertyChangedEventHandler PropertyChanged;

        public double R
        {
            get => _r;
            set
            {
                _r = value;
                OnPropertyChanged();
                CalculateLd();
            }
        }

        public double Theta
        {
            get => _theta;
            set
            {
                _theta = value;
                OnPropertyChanged();
                CalculateLd();
            }
        }

        public double LdResult
        {
            get => _ldResult;
            set
            {
                _ldResult = value;
                OnPropertyChanged();
            }
        }

        private void CalculateLd()
        {
            LdResult = _r * _theta * 100;
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
