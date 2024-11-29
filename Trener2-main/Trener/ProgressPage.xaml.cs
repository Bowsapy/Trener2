using System.Text.Json;

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

        // Naèteme JSON text ze souboru
        var json = await File.ReadAllTextAsync(filePath);

        // Deserializace JSON textu zpìt do objektu User
        var user = JsonSerializer.Deserialize<User>(json);

        return user;
    }


    public async void ChangeLabels()
    {
        // Naètení dat uživatele
        User uss = await LoadUserProgressAsync();

        // Nastavení textu pro jméno uživatele
        name_label.Text = $"{uss.Name} {uss.Surname}";

        // Seøazení workoutù podle data sestupnì
        var workoutItems = uss.GetAllWorkouts()
            .OrderByDescending(workout => workout.dateTime) // Seøazení podle data
            .Select(workout => new
            {
                WorkoutName = workout.workoutName, // Název workoutu
                Date = workout.dateTime.ToString("dd.MM.yyyy HH:mm") // Datum ve èitelné podobì
            })
            .ToList();

        // Pøiøazení dat do ListView
        workoutListView.ItemsSource = workoutItems;
    }


}