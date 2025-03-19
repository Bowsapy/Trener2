using Microsoft.Maui.Controls;

namespace Trener
{
    public partial class EndOfWorkoutPage : ContentPage
    {
        public EndOfWorkoutPage()
        {
            Shell.SetNavBarIsVisible(this, false);

            InitializeComponent();
        }

        private async void OnBackClicked(object sender, EventArgs e)
        {
            // Navigace zpět
            await Application.Current.MainPage.Navigation.PushAsync(new Menu0Page());
        }
        protected override bool OnBackButtonPressed()
        {
            return true; // Zakáže tlačítko zpět
        }

    }
}
