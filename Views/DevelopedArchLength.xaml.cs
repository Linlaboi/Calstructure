namespace Calstructure.Views;
using Calstructure.ViewModels;

public partial class DevelopedArchLength : ContentPage
{
    private DevelopedArchLengthViewModel _viewModel;

    public DevelopedArchLength()
	{
		InitializeComponent();
        _viewModel = new DevelopedArchLengthViewModel();
        BindingContext = _viewModel;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        _viewModel.R = 0;
        _viewModel.Theta = 0;
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await DisplayAlert("Factors Explanation",
     "Here is the meaning of each factor:\n\n" +
     "Eli: [Explanation for W]\n" +
     "θ: [Explanation for Ls]\n" +
     "Ld: [Explanation for H]\n" +
     "Pei []\n",
     "OK");
    }
}