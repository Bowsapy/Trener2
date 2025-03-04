using Microsoft.Maui.Controls;

namespace Trener
{
    public partial class EndOfWorkoutPage : ContentPage
    {
        public EndOfWorkoutPage()
        {
            InitializeComponent();
        }

        private async void OnBackClicked(object sender, EventArgs e)
        {
            // Navigace zpět
            await Application.Current.MainPage.Navigation.PushAsync(new Menu0Page());
        }
    }
}
