namespace Calstructure.Views;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Layouts;
using System;
using ViewModels;

public partial class ParabolicCalculatorPage : ContentPage
{
    private ParabolicCalculatorViewModel _viewModel;

    public ParabolicCalculatorPage()
    {
        InitializeComponent();
        _viewModel = new ParabolicCalculatorViewModel();
        BindingContext = _viewModel;

    }

    private void Button_Clear_Clicked(object sender, EventArgs e)
    {
        wEntry.Text = "";
        lsEntry.Text = "";
        hEntry.Text = "";
        _viewModel.Result = 0;
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Factors Explanation",
        "ความหมายของแต่ละตัวแปร:\n\n" +
        "W: แรงอดที่กดทับที่กระทบตามรอยแนวยาว\n" +
        "Ls: ระยะซัพพอร์ต A  ถึง B\n" +
        "H: ระยะซัพพอร์ตถึงจุดสูงสุดของส่วนโค้ง\n",
        "OK");
    }
}