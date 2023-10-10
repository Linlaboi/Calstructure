using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace Calstructure.ViewModels
{
    public class ParabolicCalculatorViewModel : INotifyPropertyChanged
    {
        private double _w;
        private double _ls;
        private double _h;
        private double _result;

        public event PropertyChangedEventHandler PropertyChanged;

        public double W
        {
            get => _w;
            set
            {
                _w = value;
                OnPropertyChanged();
                CalculatePr();
            }
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }

        public double Ls
        {
            get => _ls;
            set
            {
                _ls = value;
                OnPropertyChanged();
                CalculatePr();
            }
        }

        public double H
        {
            get => _h;
            set
            {
                _h = value;
                OnPropertyChanged();
                CalculatePr();
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

        private void CalculatePr()
        {
            if (H == 0 || Ls == 0)
            {
                Result = 0;
                return;
            }

            Result = (W * Math.Pow(Ls, 2)) / (8 * H) * Math.Sqrt(1 + (16 * Math.Pow(H, 2) / Math.Pow(Ls, 2)));
        }
    }
}
