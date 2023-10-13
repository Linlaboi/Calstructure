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
		_viewModel.E = 0;
        _viewModel.Lo = 0;
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
      "ความหมายของแต่ละตัวแปร:\n\n" +
      "E:โดดูลัสของสภาพยืดยุ่น\n" +
      "Lo: โมเมนต์ความเฉื่อย\n" +
      "Ko: ค่าคงที่ของระยะประสิทธิผล\n" +
      "Ldb: ระยะความโค้ง, CM\n",
      "OK");
    }
}