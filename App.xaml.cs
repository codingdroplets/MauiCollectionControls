using MauiCollectionControls.Pages;

namespace MauiCollectionControls;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new CollectionViewDemo();
	}
}
