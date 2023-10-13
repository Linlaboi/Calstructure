using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Calstructure.ViewModels
{
    public class ArchAngle : INotifyPropertyChanged
    {
        private double _degrees;
        private double _radians;

        public double Degrees
        {
            get => _degrees;
            set
            {
                if (_degrees != value)
                {
                    _degrees = value;
                    OnPropertyChanged(nameof(Degrees));

                    ConvertToRadians();
                }
            }
        }

        public double Radians
        {
            get => _radians;
            private set
            {
                if (_radians != value)
                {
                    _radians = value;
                    OnPropertyChanged(nameof(Radians));
                }
            }
        }

        private void ConvertToRadians()
        {
            Radians = (System.Math.PI / 180.0) * Degrees;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
