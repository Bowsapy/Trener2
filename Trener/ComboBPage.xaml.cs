namespace Trener;

public partial class ComboBPage : ContentPage
{
	public ComboBPage()
	{
		InitializeComponent();
	}
    public void OnBackButtonClicked(object sender, EventArgs e)
    {

        App.Current.MainPage = new NavigationPage(new StartPage1());

    }
    private void StartFunc1(object sender, EventArgs e)
    {
        App.Current.MainPage = new NavigationPage(new ActionPage(AllWorkouts.TechWorkouts.combobuild_workout));

    }
    private void StartFunc2(object sender, EventArgs e)
    {
        App.Current.MainPage = new NavigationPage(new ActionPage(AllWorkouts.TechWorkouts.combobuild_workout2));

    }
    private void StartFunc3(object sender, EventArgs e)
    {
        App.Current.MainPage = new NavigationPage(new ActionPage(AllWorkouts.TechWorkouts.combobuild_workout3));

    }
    private void StartFunc4(object sender, EventArgs e)
    {
        App.Current.MainPage = new NavigationPage(new ActionPage(AllWorkouts.TechWorkouts.combobuild_workout4));

    }
}