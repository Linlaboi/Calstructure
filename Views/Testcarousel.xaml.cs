using Calstructure.Models;


namespace Calstructure.Views;

public partial class Testcarousel : ContentPage
{
    public Testcarousel()
    {
        InitializeComponent();
        var items = new List<CollectionItem>
        {
            new CollectionItem { ImageUrl = "parabola.png", Title = "Parabolic", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. In massa tempor nec feugiat nisl pretium fusce id velit. Eu consequat ac felis donec et odio pellentesque. Vestibulum lorem sed risus ultricies tristique nulla aliquet." },
            new CollectionItem { ImageUrl = "circular.png", Title = "Circular", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. In massa tempor nec feugiat nisl pretium fusce id velit. Eu consequat ac felis donec et odio pellentesque. Vestibulum lorem sed risus ultricies tristique nulla aliquet." },
            new CollectionItem { ImageUrl = "dotnet_bot.svg", Title = "In-Plane Strength", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. In massa tempor nec feugiat nisl pretium fusce id velit. Eu consequat ac felis donec et odio pellentesque. Vestibulum lorem sed risus ultricies tristique nulla aliquet." },
            new CollectionItem { ImageUrl = "dotnet_bot.svg", Title = "Out-of-Plane Strength", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. In massa tempor nec feugiat nisl pretium fusce id velit. Eu consequat ac felis donec et odio pellentesque. Vestibulum lorem sed risus ultricies tristique nulla aliquet." },
        };
        carouselView.ItemsSource = items;

    }
}