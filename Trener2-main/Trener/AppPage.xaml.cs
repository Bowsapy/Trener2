namespace Trener;

public partial class AppPage : ContentPage
{
    public AppPage()
    {
        InitializeComponent();
    }
    public void Click(object sender, EventArgs e)
    {

        App.Current.MainPage = new NavigationPage(new Menu0Page());

    }
}