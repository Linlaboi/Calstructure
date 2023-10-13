using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Calstructure.ViewModels
{
    public class AreaCalculatorViewModel : INotifyPropertyChanged
    {
        private double _side;
        private double _length;
        private double _width;
        private string _result;

        public event PropertyChangedEventHandler PropertyChanged;

        public double Side
        {
            get => _side;
            set { _side = value; OnPropertyChanged(); CalculateArea(); }
        }

        public double Length
        {
            get => _length;
            set { _length = value; OnPropertyChanged(); CalculateArea(); }
        }

        public double Width
        {
            get => _width;
            set { _width = value; OnPropertyChanged(); CalculateArea(); }
        }

        public string Result
        {
            get => _result;
            set { _result = value; OnPropertyChanged(); }
        }

        public Command CalculateCommand => new Command(CalculateArea);

        private void CalculateArea()
        {
            if (Side > 0)
            {
                Result = (Side * Side).ToString();
            }
            else if (Length > 0 && Width > 0)
            {
                Result = (Length * Width).ToString();
            }
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
