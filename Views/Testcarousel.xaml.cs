using Calstructure.Models;
using Calstructure.Views;
using Microsoft.Maui.Controls;
using System;
using System.Diagnostics;

namespace Calstructure.Views;

public partial class Testcarousel : ContentPage
{    

    public Testcarousel()
    {
        InitializeComponent();
        BindingContext = this;
        var items = new List<CollectionItem>
        {
            new CollectionItem { ImageUrl = "parabola.png", Title = "Parabolic", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. In massa tempor nec feugiat nisl pretium fusce id velit. Eu consequat ac felis donec et odio pellentesque. Vestibulum lorem sed risus ultricies tristique nulla aliquet." },
            new CollectionItem { ImageUrl = "circular.png", Title = "Circular", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. In massa tempor nec feugiat nisl pretium fusce id velit. Eu consequat ac felis donec et odio pellentesque. Vestibulum lorem sed risus ultricies tristique nulla aliquet." },
            new CollectionItem { ImageUrl = "dotnet_bot.svg", Title = "In-Plane Strength", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. In massa tempor nec feugiat nisl pretium fusce id velit. Eu consequat ac felis donec et odio pellentesque. Vestibulum lorem sed risus ultricies tristique nulla aliquet." },
            new CollectionItem { ImageUrl = "dotnet_bot.svg", Title = "Out-of-Plane Strength", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. In massa tempor nec feugiat nisl pretium fusce id velit. Eu consequat ac felis donec et odio pellentesque. Vestibulum lorem sed risus ultricies tristique nulla aliquet." },
        };
        carouselView.ItemsSource = items;
        var navigationPage = new NavigationPage(this);
        Application.Current.MainPage = navigationPage;
    }

    private async void Button_Title(object sender, EventArgs e)
    {
        int selectedIndex = carouselView.Position;

        if (carouselView.ItemsSource is IList<CollectionItem> items && selectedIndex >= 0 && selectedIndex < items.Count)
        {
            var selectedItem = items[selectedIndex];
            string pageTitle = selectedItem.Title;

            switch (pageTitle)
            {
                case "Parabolic":
                    await Navigation.PushModalAsync(new ParabolicCalculatorPage());
                    break;
                case "Circular":
                    await Navigation.PushModalAsync(new CircularCalculatorPage());
                    break;
                case "In-Plane Strength":
                    await Navigation.PushModalAsync(new InPlaneStrengthCalculatorPage());
                    break;
                case "Out-of-Plane Strength":
                    await Navigation.PushModalAsync(new OutOfPlaneCalculatorPage());
                    break;
                default:
                    await Navigation.PushModalAsync(new Testcarousel());
                    break;
            }
        }
    }
}