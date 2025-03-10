using System.Text.Json;
using Trener.Resources; // Namespace, kde jsou generované Resources


namespace Trener;

public partial class ProgressPage : ContentPage
{
	public ProgressPage()
	{
		InitializeComponent();
        ChangeLabels();

	}
	
    public async Task<User> LoadUserProgressAsync()
    {
        var filePath = Path.Combine(FileSystem.AppDataDirectory, "UserProgress2.json");

        // Zkontrolujeme, zda soubor existuje
        if (!File.Exists(filePath))
        {
            return new User(); // Pokud soubor neexistuje, vrátíme nový prázdný objekt User
        }

        // Načteme JSON text ze souboru
        var json = await File.ReadAllTextAsync(filePath);

        // Deserializace JSON textu zpět do objektu User
        var user = JsonSerializer.Deserialize<User>(json);

        return user;
    }
    


    public async void ChangeLabels()
    {
        // Načtení dat uživatele
        User uss = await LoadUserProgressAsync();

        // Nastavení textu pro jméno uživatele




        // Seřazení workoutů podle data sestupně
        var workoutItems = uss.GetAllWorkouts()
            .OrderByDescending(workout => workout.dateTime) // Seřazení podle data
            .Select(workout => new
            {
                WorkoutName = workout.workoutName, // Název workoutu
                Date = workout.dateTime.ToString("dd.MM.yyyy HH:mm") // Datum ve čitelné podobě
            })
            .ToList();

        // Přiřazení dat do ListView
        workoutListView.ItemsSource = workoutItems;

        int uniqueWorkoutsCount = uss.CountUniqueWorkouts();

        progress_label.Text = uniqueWorkoutsCount + " / 20 = " +
                              ((uniqueWorkoutsCount / 20.0) * 100).ToString("0.0") + "%";
        string rank;
        switch (uniqueWorkoutsCount)
        {
            case int n when n == 20:
                rank = Trener.Resources.Languages.objectsStrings.Champ;
                break;
            case int n when n > 10:
                rank = Trener.Resources.Languages.objectsStrings.pro;
                break;
            case int n when n > 5:
                rank = Trener.Resources.Languages.objectsStrings.semi_pro;
                break;
            default:
                rank = Trener.Resources.Languages.objectsStrings.amateur;
                break;
        }

        name_label.Text = $"{rank}";


    }


}