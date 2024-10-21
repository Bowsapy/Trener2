namespace Trener;

public partial class BegiPage2 : ContentPage
{
    public BegiPage2()
    {
        InitializeComponent();
    }
    private void StartFunc(object sender, EventArgs e)
    {
        App.Current.MainPage = new NavigationPage(new ActionPage(AllWorkouts.TechWorkouts.basic_strikes));

    }
    private void StartFunc2(object sender, EventArgs e)
    {
        App.Current.MainPage = new NavigationPage(new ActionPage(AllWorkouts.TechWorkouts.basic_defence));

    }
    private void StartFunc3(object sender, EventArgs e)
    {
        App.Current.MainPage = new NavigationPage(new ActionPage(AllWorkouts.TechWorkouts.basic_movement));

    }
    private void StartFunc4(object sender, EventArgs e)
    {
        App.Current.MainPage = new NavigationPage(new ActionPage(AllWorkouts.TechWorkouts.basic_all));

    }
    public void OnBackButtonClicked(object sender, EventArgs e)
    {

        App.Current.MainPage = new NavigationPage(new StartPage1());


    }

}