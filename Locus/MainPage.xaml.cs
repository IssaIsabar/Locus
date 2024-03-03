using Locus.Pages;

namespace Locus;
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Userpage());
    }
}


