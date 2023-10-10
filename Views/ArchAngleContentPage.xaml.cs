using Calstructure.ViewModels;

namespace Calstructure.Views;

public partial class ArchAngleContentPage : ContentPage
{
    private ArchAngle _viewModel;

    public ArchAngleContentPage()
	{
		InitializeComponent();
        _viewModel = new ArchAngle();
        BindingContext = _viewModel;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        nEntry.Text = "";
        _viewModel.Result = 0;
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await DisplayAlert("Factors Explanation",
     "Here is the meaning of each factor:\n\n" +
     "n: [Explanation for W]\n" +
     "Rad: [Explanation for Ls]\n",
     "OK");
    }
}