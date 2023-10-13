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
        private double _n;
        private double _Result;

        public event PropertyChangedEventHandler PropertyChanged;

        public double N
        {
            get => _n;
            set
            {
                _n = value;
                OnPropertyChanged();
                CalculateTheta();
            }
        }

        public double Result
        {
            get => _Result;
            set
            {
                _Result = value;
                OnPropertyChanged();
            }
        }

        private void CalculateTheta()
        {
            Result = (Math.PI / 180) * _n;
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
