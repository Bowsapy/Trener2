namespace Trener;

public partial class TechPage : ContentPage
{
	public TechPage()
	{
		InitializeComponent();
	}
    public void OnBackButtonClicked(object sender, EventArgs e)
    {

        App.Current.MainPage = new NavigationPage(new MainPage());

    }
    public void ActFunc(object sender, EventArgs e)
    {

        App.Current.MainPage = new NavigationPage(new BegiPage2());

    }
    

}