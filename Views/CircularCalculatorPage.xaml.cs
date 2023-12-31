﻿namespace Calstructure.Views;
using Calstructure.ViewModels;

public partial class CircularCalculatorPage : ContentPage
{
	private CircularViewModel _viewModel;
	public CircularCalculatorPage()
	{
		InitializeComponent();
		_viewModel = new CircularViewModel();
		BindingContext = _viewModel;
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        _viewModel.Q = 0;
        _viewModel.R = 0;
        _viewModel.PrResult = 0;
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await DisplayAlert("Factors Explanation",
     "ความหมายของแต่ละตัวแปร:\n\n" +
     "Q: แรงที่กระทำต่อโครงสร้าง, kN/M\n" +
     "R: รัศมีจุดศูนย์ถ่วงของความโค้ง\n",
     "OK");
    }

    private async void Button_Goback(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}
