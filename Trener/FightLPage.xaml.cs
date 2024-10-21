namespace Trener;

public partial class ComboBFunc : ContentPage
{
	public ComboBFunc()
	{
		InitializeComponent();
	}
	    public void OnBackButtonClicked(object sender, EventArgs e)
    {

        App.Current.MainPage = new NavigationPage(new StartPage1());


    }
}