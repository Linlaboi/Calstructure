namespace Calstructure.Views;

public partial class LengthConverter : ContentPage
{
	public LengthConverter()
	{
		InitializeComponent();
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
}