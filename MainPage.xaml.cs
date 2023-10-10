using Calstructure.ViewModels;
using Calstructure.Views;

namespace Calstructure
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCircularButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CircularCalculatorPage());
        }

        private  async void OnParabolicButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ParabolicCalculatorPage());

        }

        private async void OnInPlaneStrengthButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InPlaneStrengthCalculatorPage());

        }

        private async void OnOutOfPlaneStrengthButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OutOfPlaneCalculatorPage());

        }
    }
}