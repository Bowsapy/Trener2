namespace Trener;

public partial class StartPage1 : ContentPage
{

    public StartPage1()
    {
        InitializeComponent();
    }
    public void OnBackButtonClicked(object sender, EventArgs e)
    {

        App.Current.MainPage = new NavigationPage(new MenuPage1());

    }
    private void TechFunc(object sender, EventArgs e)
    {
        App.Current.MainPage = new NavigationPage(new BegiPage2());

    }
    private void AdvFunc(object sender, EventArgs e)
    {
        App.Current.MainPage = new NavigationPage(new AdvaPage());

    }
    private void ComboBFunc(object sender, EventArgs e)
    {
        App.Current.MainPage = new NavigationPage(new ComboBPage());

    }
    private void FitFunc(object sender, EventArgs e)
    {
        App.Current.MainPage = new NavigationPage(new FitPage());

    }
    private void StylFunc(object sender, EventArgs e)
    {

        App.Current.MainPage = new NavigationPage(new StylPage());

    }

}