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
        var fadeinresult = new Animation((value) =>
        {
            resultLabel.Opacity = value;
        }, 0, 1);

        resultLabel.Animate("Opacity", fadeinresult, length: 500);
        resultLabel.IsVisible = true;

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
            case "ไร่":
                resultInSquareMeters = inputValue * 4 * 100 * 4;
                break;
            case "งาน":
                resultInSquareMeters = inputValue * 100 * 4;
                break;
            case "ตารางวา":
                resultInSquareMeters = inputValue * 4;
                break;
            case "ตารางเมตร":
                resultInSquareMeters = inputValue;
                break;
        }

        double finalResult = 0;
        switch (outputUnitPicker.SelectedItem.ToString())
        {
            case "ไร่":
                finalResult = resultInSquareMeters / (4 * 100 * 4);
                break;
            case "งาน":
                finalResult = resultInSquareMeters / (100 * 4);
                break;
            case "ตารางวา":
                finalResult = resultInSquareMeters / 4;
                break;
            case "ตารางเมตร":
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

    private async void inputUnitPicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        /*var fadeoutinput = new Animation((value) =>
        {
            inputSelect.Opacity = value;
        },1,0);

        var fadeinoutput = new Animation((value) =>
        {
            outputSelect.Opacity = value;
        }, 0, 1);

        inputSelect.Animate("Opacity", fadeoutinput, length: 500);
        await Task.Delay(1000);
        outputSelect.Animate("Opacity", fadeinoutput, length: 500);*/

        await InputValue.FadeTo(0, 500);
        await inputSelect.FadeTo(0, 500);
        await Task.Delay(500);
        await outputSelect.FadeTo(1, 500);
        await Task.Delay(500);
    }

    private async void outputUnitPicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        /*var fadeoutoutput = new Animation((value) =>
        {
            outputSelect.Opacity = value;
        }, 1, 0);

        var fadeinvalue = new Animation((value) =>
        {
            InputValue.Opacity = value;
        }, 0, 1);
        var fadeinfield = new Animation((value) =>
        {
            inputField.Opacity = value;
        }, 0, 1);

        inputSelect.Animate("Opacity", fadeoutoutput, length: 500);
        await Task.Delay(600);
        outputSelect.Animate("Opacity", fadeinvalue, length: 500);
        await Task.Delay(200);
        inputField.Animate("Opacity", fadeinfield, length: 500);
        inputField.IsVisible = true;*/

        await outputSelect.FadeTo(0, 500);
        await Task.Delay(500);
        await InputValue.FadeTo(1, 500);
        await Task.Delay(200);
        await inputField.FadeTo(1, 500);
        inputField.IsVisible = true;

    }
}