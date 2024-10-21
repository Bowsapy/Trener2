namespace Trener;

public partial class FitPage : ContentPage
{
	public FitPage()
	{
		InitializeComponent();
	}
    public void OnBackButtonClicked(object sender, EventArgs e)
    {

        App.Current.MainPage = new NavigationPage(new StartPage1());


    }
    public void Cardio1Func(object sender, EventArgs e)
    {

        App.Current.MainPage = new NavigationPage(new ActionPage2(AllWorkouts.FitnessWorkouts.cardio1));


    }
    public void Cardio2Func(object sender, EventArgs e)
    {

        App.Current.MainPage = new NavigationPage(new ActionPage2(AllWorkouts.FitnessWorkouts.cardio2));


    }
    public void Core1Func(object sender, EventArgs e)
    {

        App.Current.MainPage = new NavigationPage(new ActionPage2(AllWorkouts.FitnessWorkouts.core1));


    }
    public void Core2Func(object sender, EventArgs e)
    {

        App.Current.MainPage = new NavigationPage(new ActionPage2(AllWorkouts.FitnessWorkouts.core2));


    }
}
