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
}