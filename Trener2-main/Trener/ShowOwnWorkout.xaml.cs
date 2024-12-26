namespace Trener;

public partial class ShowOwnWorkout : ContentPage
{
	WorkoutClass workout;
	public ShowOwnWorkout(WorkoutClass workout)
	{
		this.workout = workout;
		InitializeComponent();
        ShowWorkout();
	}

	public void ShowWorkout() {

		string text = "";
		foreach (ComboClass combo in this.workout.Combos) {

			text += combo.Name + ",\n";


		}


		allcombos_label.Text = text;
		text = "";

	}



}