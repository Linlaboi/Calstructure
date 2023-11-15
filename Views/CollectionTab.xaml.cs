namespace Calstructure.Views;
using Calstructure.ViewModels;
using Calstructure.CallMall;
using System;
using CalMall;

public partial class CollectionTab : TabbedPage
{
    private AreaCalculatorViewModel AreaviewModel;
    private DevelopedArchLengthViewModel DevelopedviewModel;
    private ArchAngle AngleviewModel;


    public CollectionTab()
	{
		InitializeComponent();
        AreaviewModel = new AreaCalculatorViewModel();
        this.BindingContext = AreaviewModel;
        DevelopedviewModel = new DevelopedArchLengthViewModel();
        this.BindingContext = DevelopedviewModel;
        AngleviewModel = new ArchAngle();
        this.BindingContext = AngleviewModel;

        AreaPicker.SelectedIndexChanged += OnAreaPickerSelectionChanged;
    }

    private void OnAreaPickerSelectionChanged(object sender, EventArgs e)
    {
        if (AreaPicker.SelectedItem != null)
        {
            AreaviewModel.Result = "0";

            switch (AreaPicker.SelectedItem.ToString())
            {
                case "Square":
                    SideEntry.IsVisible = true;
                    LengthEntry.IsVisible = false;
                    WidthEntry.IsVisible = false;
                    break;

                case "UnequalRectangle":
                    SideEntry.IsVisible = false;
                    LengthEntry.IsVisible = true;
                    WidthEntry.IsVisible = true;
                    break;

                default:
                    break;
            }
        }
    }

    private void ClearEntries(object sender, EventArgs e)
    {
        SideEntry.Text = "";
        LengthEntry.Text = "";
        WidthEntry.Text = "";
        AreaviewModel.Result = "0";
    }

    private void OnTextChanged(object sender, TextChangedEventArgs e)
    {
        ConvertAndDisplayValue();
    }

    private void ConvertAndDisplayValue()
    {
        if (!double.TryParse(inputField.Text, out double inputValue))
        {
            resultLabel.Text = "Please enter a valid number!";
            return;
        }

        double resultInSquareMeters = 0;

        switch (inputUnitPicker.SelectedItem.ToString())
        {
            case "Rai":
                resultInSquareMeters = inputValue * 4 * 100 * 4;
                break;
            case "Ngan":
                resultInSquareMeters = inputValue * 100 * 4;
                break;
            case "Square Wah":
                resultInSquareMeters = inputValue * 4;
                break;
            case "Square Meter":
                resultInSquareMeters = inputValue;
                break;
        }

        double finalResult = 0;
        switch (outputUnitPicker.SelectedItem.ToString())
        {
            case "Rai":
                finalResult = resultInSquareMeters / (4 * 100 * 4);
                break;
            case "Ngan":
                finalResult = resultInSquareMeters / (100 * 4);
                break;
            case "Square Wah":
                finalResult = resultInSquareMeters / 4;
                break;
            case "Square Meter":
                finalResult = resultInSquareMeters;
                break;
        }

        resultLabel.Text = $"{finalResult} {outputUnitPicker.SelectedItem}";
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        DevelopedviewModel.R = 0;
        DevelopedviewModel.Theta = 0;
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await DisplayAlert("Factors Explanation","ความหมายของแต่ละตัวแปร:\n\n" + "R: รัศมีจุดศูนย์ถ่วงของความโค้ง\n" +"θ: มุมรัศมีความโค้ง\n",
            "OK");
    }

    private void Button_Clicked_2(object sender, EventArgs e)
    {
        r2Entry.Text = "";
        dEntry.Text = "";
        AngleviewModel.Result = 0;
    }

    private async void Button_Clicked_3(object sender, EventArgs e)
    {
        await DisplayAlert("Factors Explanation","ความหมายของแต่ละตัวแปร:\n\n" +"n: รัศมีจุดศูนย์ถ่วงของความโค้ง\n" +"Rad: ระยะรัศมีจนถึงจุดที่สนใจ\n",
            "OK");
    }

    private async void Button_Clicked_4(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new EquationPage(1));
    }

    private async void Button_Clicked_5(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new EquationPage(2));

    }

    private async void Button_Clicked_6(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new EquationPage(3));

    }
}