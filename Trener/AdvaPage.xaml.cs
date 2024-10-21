namespace Trener;

public partial class AdvaPage : ContentPage
{
	public AdvaPage()
	{
		InitializeComponent();
	}
    public void OnBackButtonClicked(object sender, EventArgs e)
    {

        App.Current.MainPage = new NavigationPage(new StartPage1());


    }
    private void StartFunc1(object sender, EventArgs e)
    {
        App.Current.MainPage = new NavigationPage(new ActionPage(AllWorkouts.TechWorkouts.longercombos_workout));

    }

    private void StartFunc2(object sender, EventArgs e)
    {
        App.Current.MainPage = new NavigationPage(new ActionPage(AllWorkouts.TechWorkouts.longercombosWithMoves_workout));

    }

    private void StartFunc3(object sender, EventArgs e)
    {
        App.Current.MainPage = new NavigationPage(new ActionPage(AllWorkouts.TechWorkouts.headmovement_workout));

    }

    private void StartFunc4(object sender, EventArgs e)
    {
        App.Current.MainPage = new NavigationPage(new ActionPage(AllWorkouts.TechWorkouts.longercombosWithAll_workout));

    }

}