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
            return new User(); // Pokud soubor neexistuje, vr�t�me nov� pr�zdn� objekt User
        }

        // Na�teme JSON text ze souboru
        var json = await File.ReadAllTextAsync(filePath);

        // Deserializace JSON textu zp�t do objektu User
        var user = JsonSerializer.Deserialize<User>(json);

        return user;
    }


    public async void ChangeLabels()
    {
        // Na�ten� dat u�ivatele
        User uss = await LoadUserProgressAsync();

        // Nastaven� textu pro jm�no u�ivatele
        name_label.Text = $"{uss.Name} {uss.Surname}";

        // Se�azen� workout� podle data sestupn�
        var workoutItems = uss.GetAllWorkouts()
            .OrderByDescending(workout => workout.dateTime) // Se�azen� podle data
            .Select(workout => new
            {
                WorkoutName = workout.workoutName, // N�zev workoutu
                Date = workout.dateTime.ToString("dd.MM.yyyy HH:mm") // Datum ve �iteln� podob�
            })
            .ToList();

        // P�i�azen� dat do ListView
        workoutListView.ItemsSource = workoutItems;
    }


}