using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Calstructure.ViewModels
{
    public class AxialCompressionViewModel : INotifyPropertyChanged
    {
        private double _q;
        private double _r;
        private double _pr;
        public event PropertyChangedEventHandler PropertyChanged;


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

        public double Pr
        {
            get => _pr;
            set
            {
                _pr = value;
                OnPropertyChanged();
            }
        }

        private void CalculatePr()
        {
            Pr = Q * R;
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
