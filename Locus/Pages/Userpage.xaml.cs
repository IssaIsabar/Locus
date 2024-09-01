namespace Locus.Pages;

public partial class Userpage : ContentPage
{
	public Userpage()
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
        NavigationPage.SetBackButtonTitle(this, null);
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new InsurancePage());
    }
}