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
     "ความหมายของแต่ละตัวแปร:\n\n" +
     "R: รัศมีจุดศูนย์ถ่วงของความโค้ง\n" +
     "θ: มุมรัศมีความโค้ง\n",
     "OK");
    }
}