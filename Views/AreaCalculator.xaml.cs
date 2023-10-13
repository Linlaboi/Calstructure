namespace Calstructure.Views;
using Calstructure.ViewModels;

public partial class AreaCalculator : ContentPage
{
    private AreaCalculatorViewModel _viewModel;

    public AreaCalculator()
    {
        InitializeComponent();
        _viewModel = new AreaCalculatorViewModel();
        this.BindingContext = _viewModel;

        AreaPicker.SelectedIndexChanged += OnAreaPickerSelectionChanged;
    }

    private void OnAreaPickerSelectionChanged(object sender, EventArgs e)
    {
        if (AreaPicker.SelectedItem != null)
        {
            _viewModel.Result = "0";

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
        _viewModel.Result = "0";
    }
}