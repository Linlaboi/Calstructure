using CalMall;
using Microsoft.Maui.Controls.PlatformConfiguration.GTKSpecific;

namespace Calstructure.CallMall;

public partial class SelectedPage : ContentPage
{
	public SelectedPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new EquationPage(1));
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new EquationPage(2));

    }

    private async void Button_Clicked_2(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new EquationPage(3));

    }
}