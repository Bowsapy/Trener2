namespace Trener;

public partial class StylPage : ContentPage
{
	public StylPage()
	{
		InitializeComponent();
	}
    public void OnBackButtonClicked(object sender, EventArgs e)
    {

        App.Current.MainPage = new NavigationPage(new StartPage1());

    }
    public void CounterPuncherFunc(object sender, EventArgs e)
    {

        App.Current.MainPage = new NavigationPage(new ActionPage(AllWorkouts.TechWorkouts.counterpuncher_workout));

    }
    public void SwitchhittingFunc(object sender, EventArgs e)
    {

        App.Current.MainPage = new NavigationPage(new ActionPage(AllWorkouts.TechWorkouts.switchhitting_workout));

    }
    public void PressurefighterFunc(object sender, EventArgs e)
    {

        App.Current.MainPage = new NavigationPage(new ActionPage(AllWorkouts.TechWorkouts.pressurefighter_workout));

    }
    public void LRfighterFunc(object sender, EventArgs e)
    {

        App.Current.MainPage = new NavigationPage(new ActionPage(AllWorkouts.TechWorkouts.longrangefighter_workout));

    }


}