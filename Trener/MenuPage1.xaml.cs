namespace Trener;

public partial class MenuPage1 : ContentPage
{

    public MenuPage1()
    {
        InitializeComponent();
    }
    public void OnBackButtonClicked(object sender, EventArgs e)
    {

        App.Current.MainPage = new NavigationPage(new MainPage());

    }

    public void TechFunc(object sender, EventArgs e)
    {

        App.Current.MainPage = new NavigationPage(new StartPage1());

    }
    private void FitFunc(object sender, EventArgs e)
    {
        App.Current.MainPage = new NavigationPage(new FitPage());

    }


}