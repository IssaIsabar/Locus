namespace Locus.Pages;

public partial class Userpage : ContentPage
{
	public Userpage()
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
        NavigationPage.SetBackButtonTitle(this, null);
    }
}