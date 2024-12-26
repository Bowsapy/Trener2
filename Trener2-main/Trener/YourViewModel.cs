using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace Trener
{
    public class YourViewModel
    {
        public ICommand NavigateCommandToLeft { get; }
        public ICommand NavigateCommandToRight { get; }
        public ICommand StartTechWorkout { get; }
        public ICommand StartFitWorkout { get; }

        public YourViewModel()
        {
            NavigateCommandToRight = new Command<string>(ExecuteNavigateCommandToRight);
            NavigateCommandToLeft = new Command<string>(ExecuteNavigateCommandToLeft);
            StartTechWorkout = new Command<string>(ExecuteStartTechWorkout);
            StartFitWorkout = new Command<string>(ExecuteStartFitWorkout);
        }

        private async void ExecuteNavigateCommandToRight(string param)
        {
            Page pageToNavigate = null;

            switch (param)
            {
                case "START":
                    pageToNavigate = new Menu1Page();
                    break;
                case "ABOUT APP":
                    pageToNavigate = new AppPage();
                    break;
                case "PROGRESS":
                    pageToNavigate = new ProgressPage();
                    break;
                case "TECH":
                    pageToNavigate = new TechPage();
                    break;
                case "FIT":
                    pageToNavigate = new FitPage();
                    break;
                case "MENU":
                    pageToNavigate = new Menu0Page();
                    break;
                case "TECH 1":
                    pageToNavigate = new Tech1Page();
                    break;
                case "TECH 2":
                    pageToNavigate = new Tech2Page();
                    break;
                case "COMBO":
                    pageToNavigate = new ComboBPage();
                    break;
                case "STYLES":
                    pageToNavigate = new StylesPage();
                    break;
                case "CARDIO":
                    pageToNavigate = new CardioPage();
                    break;
                case "POWER":
                    pageToNavigate = new CoreAndPower();
                    break;
                case "OWN":
                    pageToNavigate = new MakeYourOwnPage();
                    break;
                case "QUIT":
                    Application.Current.Quit();
                    return;
            }

            if (pageToNavigate != null)
            {
                await Application.Current.MainPage.Navigation.PushAsync(pageToNavigate);
            }
        }

        private async void ExecuteNavigateCommandToLeft(string param)
        {
            await Application.Current.MainPage.Navigation.PopAsync();
        }

        private async void ExecuteStartTechWorkout(string param)
        {
            WorkoutClass workout = null;

            switch (param)
            {
                case "BASIC STRIKES":
                    workout = AllWorkouts.TechWorkouts.Technique1.basic_punches;
                    break;
                case "BASIC DEFENCE":
                    workout = AllWorkouts.TechWorkouts.Technique1.basic_defence;
                    break;
                case "BASIC MOVEMENT":
                    workout = AllWorkouts.TechWorkouts.Technique1.basic_movement;
                    break;
                case "BASIC ALL":
                    workout = AllWorkouts.TechWorkouts.Technique1.basic_all;
                    break;
                case "LONGER COMBOS":
                    workout = AllWorkouts.TechWorkouts.Technique2.longercombos_workout;
                    break;
                case "LONGER COMBOS WITH MOVEMENT":
                    workout = AllWorkouts.TechWorkouts.Technique2.longercombosWithMoves_workout;
                    break;
                case "HEADMOVEMENT":
                    workout = AllWorkouts.TechWorkouts.Technique2.headmovement_workout;
                    break;
                case "LONGER COMBOS WITH ALL":
                    workout = AllWorkouts.TechWorkouts.Technique2.longercombosWithAll_workout;
                    break;
                case "COMBO 1":
                    workout = AllWorkouts.TechWorkouts.ComboBuilder.combobuild_workout;
                    break;
                case "COMBO 2":
                    workout = AllWorkouts.TechWorkouts.ComboBuilder.combobuild_workout2;
                    break;
                case "COMBO 3":
                    workout = AllWorkouts.TechWorkouts.ComboBuilder.combobuild_workout3;
                    break;
                case "COMBO 4":
                    workout = AllWorkouts.TechWorkouts.ComboBuilder.combobuild_workout4;
                    break;
                case "COUNTER PUNCHER":
                    workout = AllWorkouts.TechWorkouts.Styles.counterpuncher_workout;
                    break;
                case "PRESSURE FIGHTER":
                    workout = AllWorkouts.TechWorkouts.Styles.pressurefighter_workout;
                    break;
                case "LONGRANGE FIGHTER":
                    workout = AllWorkouts.TechWorkouts.Styles.longrangefighter_workout;
                    break;
                case "SWITCH HITTER":
                    workout = AllWorkouts.TechWorkouts.Styles.switchhitting_workout;
                    break;
                case "QUIT":
                    Application.Current.Quit();
                    return;
            }

            if (workout != null)
            {
                await Application.Current.MainPage.Navigation.PushAsync(new ActionPage(workout));
            }
        }

        private async void ExecuteStartFitWorkout(string param)
        {
            FitnessWorkoutClass workout = null;

            switch (param)
            {
                case "CARDIO 1":
                    workout = AllWorkouts.FitnessWorkouts.Cardio.cardio1;
                    break;
                case "CARDIO 2":
                    workout = AllWorkouts.FitnessWorkouts.Cardio.cardio1;
                    break;
                case "CARDIO 3":
                    workout = AllWorkouts.FitnessWorkouts.Cardio.cardio1;
                    break;
                case "CARDIO 4":
                    workout = AllWorkouts.FitnessWorkouts.Cardio.cardio1;
                    break;
                case "CORE 1":
                    workout = AllWorkouts.FitnessWorkouts.Cardio.cardio1;
                    break;
                case "CORE 2 ":
                    workout = AllWorkouts.FitnessWorkouts.Cardio.cardio1;
                    break;
                case "CORE 3":
                    workout = AllWorkouts.FitnessWorkouts.Cardio.cardio1;
                    break;
                case "CORE 4":
                    workout = AllWorkouts.FitnessWorkouts.Cardio.cardio1;
                    break;

                case "QUIT":
                    Application.Current.Quit();
                    return;
            }

            if (workout != null)
            {
                await Application.Current.MainPage.Navigation.PushAsync(new ActionPage2(workout));
            }
        }
    }
}
