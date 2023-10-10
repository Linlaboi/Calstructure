using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Calstructure.ViewModels
{
    public class RadiusViewModel : INotifyPropertyChanged
    {
        private double _r;
        private double _result;

        public event PropertyChangedEventHandler PropertyChanged;

        public double R
        {
            get => _r;
            set
            {
                _r = value;
                OnPropertyChanged();
                CalculateR();
            }
        }

        public double Result
        {
            get => _result;
            set
            {
                _result = value;
                OnPropertyChanged();
            }
        }


        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void CalculateR()
        {
            if (R == 0)
            {
                Result = 0;
                return;
            }

            Result = (R * 100);
        }

    }
}
