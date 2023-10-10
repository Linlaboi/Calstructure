namespace Calstructure.Views;
using Calstructure.ViewModels;
public partial class OutOfPlaneCalculatorPage : ContentPage
{
	private OutofPlaneStrengthViewModel _viewModel;
	public OutOfPlaneCalculatorPage()
	{
		InitializeComponent();
		_viewModel = new OutofPlaneStrengthViewModel();
		BindingContext = _viewModel;
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		_viewModel.Elo = 0;
		_viewModel.Ko = 0;
		_viewModel.Ldb = 0;
	}

	private async void Button_Clicked_1(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new KiTableContentPage());
	}

    private async void Button_Clicked_2(object sender, EventArgs e)
    {
        await DisplayAlert("Factors Explanation",
      "Here is the meaning of each factor:\n\n" +
      "Elo: [Explanation for W]\n" +
      "Ko: [Explanation for Ls]\n" +
      "Ldb: [Explanation for H]\n",
      "OK");
    }
}