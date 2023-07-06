using MauiCollectionControls.Models;
using Microsoft.Maui.Controls;

namespace MauiCollectionControls.Pages;

public partial class CarouselViewDemo : ContentPage
{
	public CarouselViewDemo()
	{
        InitializeComponent();

        var items = new List<CollectionItem>
        {
            new CollectionItem { Title = "Coding Droplets", Description = "Welcome to Coding Droplets" },
            new CollectionItem { Title = "Title 2", Description = "Description 2" },
            new CollectionItem { Title = "Title 3", Description = "Description 3" },
            new CollectionItem { Title = "Title 4", Description = "Description 4" },
            new CollectionItem { Title = "Title 5", Description = "Description 5" }
        };
        carouselView.ItemsSource = items;

        var pickerItems = new List<string>
        {
            "Item 1", 
            "Item 2", 
            "Item 3", 
            "Item 4", 
            "Item 5",
        };

        picker.ItemsSource = pickerItems;
    }
}