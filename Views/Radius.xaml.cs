namespace Calstructure.Views;
using Calstructure.ViewModels;
using Microsoft.Maui.Controls;

public partial class Radius : ContentPage
{
    RadiusViewModel _viewModel;

    public Radius()
	{
		InitializeComponent();
        _viewModel = new RadiusViewModel();
        BindingContext = _viewModel;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        rEntry.Text = "";
        _viewModel.Result = 0;

    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await DisplayAlert("Factors Explanation",
      "ความหมายของแต่ละตัวแปร:\n\n" +
      "R: รัศมี\n",
      "OK");
    }
}