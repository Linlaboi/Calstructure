using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Calstructure.ViewModels
{
    public class InPlaneStrengthViewModel : INotifyPropertyChanged
    {
        private double _eli;
        private double _ki;
        private double _ld;
        private double _pei;

        public event PropertyChangedEventHandler PropertyChanged;

        public double Eli
        {
            get => _eli;
            set
            {
                _eli = value;
                OnPropertyChanged();
                CalculatePei();
            }
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public double Ki
        {
            get => _ki;
            set
            {
                _ki = value;
                OnPropertyChanged();
                CalculatePei();
            }
        }

        public double Ld
        {
            get => _ld;
            set
            {
                _ld = value;
                OnPropertyChanged();
                CalculatePei();
            }
        }

        public double Pei
        {
            get => _pei;
            set
            {
                _pei = value;
                OnPropertyChanged();
            }
        }

        private void CalculatePei()
        {
            Pei = (Math.PI * Math.PI * Eli) / (Math.Pow(Ki * Ld, 2));
        }
    }
}
