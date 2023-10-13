namespace Calstructure.Views;
using Calstructure.ViewModels;
public partial class InPlaneStrengthCalculatorPage : ContentPage
{
	private InPlaneStrengthViewModel _viewModel;
    public InPlaneStrengthCalculatorPage()
	{
		InitializeComponent();
		_viewModel = new InPlaneStrengthViewModel();
        BindingContext = _viewModel;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        _viewModel.E = 0;
        _viewModel.Li = 0;
        _viewModel.Ki = 0;
        _viewModel.Ld = 0;
        _viewModel.Pei = 0;
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new KiTableContentPage());
    }

    private async void Button_Clicked_2(object sender, EventArgs e)
    {
        await DisplayAlert("Factors Explanation",
      "ความหมายของแต่ละตัวแปร:\n\n" +
      "E: โดดูลัสของสภาพยืดยุ่น\n" +
      "Li: โมเมนต์ความเฉื่อย\n" +
      "Ki: ค่าคงที่ของระยะประสิทธิผล\n" +
      "Ld: ระยะความโค้ง, CM\n",      
      "OK");
    }
}