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
        r2Entry.Text = "";
        dEntry.Text = "";
        _viewModel.Result = 0;
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await DisplayAlert("Factors Explanation",
     "ความหมายของแต่ละตัวแปร:\n\n" +
     "n: รัศมีจุดศูนย์ถ่วงของความโค้ง\n" +
     "Rad: ระยะรัศมีจนถึงจุดที่สนใจ\n",
     "OK");
    }
}