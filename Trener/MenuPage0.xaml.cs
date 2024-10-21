namespace Trener
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {

        }
        public void Click(object sender, EventArgs e)
        {

            if (sender is Button clickedButton)
            {
                switch (clickedButton.AutomationId)
                {
                    case "butStart":
                        App.Current.MainPage = new NavigationPage(new MenuPage1());

                        break;

                    case "butApp":
                        App.Current.MainPage = new NavigationPage(new AppPage());
                        break;

                    case "butProgress":
                        break;

                    case "butEnd":
                        End();
                        break;

                    default:

                        break;
                }
            }

        }
        public void End()
        {
            Application.Current.Quit();
        }
    }
}