using System.Text.Json;

using Trener.Resources; // Namespace, kde jsou generované Resources

namespace Trener;

public partial class MakeYourOwnPage : ContentPage
{
    List<IStrike> combo_list = new List<IStrike> { };
    

    public static WorkoutClass own_workout = new WorkoutClass("own",new List<ComboClass>(), 0);
   
    public MakeYourOwnPage()
    {

        InitializeComponent();
    }


    private void OnMovementClicked(object sender, EventArgs e)
    {

        var button = sender as Button;
        var param = button?.CommandParameter as string;

        if (param == null)
            return;
        switch (param)
        {

            case "step_formard":
                combo_list.Add(AllStrikes.AllMovements.step_forward);
                break;
            case "step_back":
                combo_list.Add(AllStrikes.AllMovements.step_back);
                break;

            case "step_right":
                combo_list.Add(AllStrikes.AllMovements.step_right);
                break;
            case "step_left":
                combo_list.Add(AllStrikes.AllMovements.step_left);
                break;

            case "i_sidestep":
                combo_list.Add(AllStrikes.AllMovements.i_sidestep);
                break;
            case "o_sidestep":
                combo_list.Add(AllStrikes.AllMovements.o_sidestep);
                break;

        }
        ShowText();

    }
    private void OnDefenceClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var param = button?.CommandParameter as string;

        if (param == null)
            return;
        switch (param)
        {
            case "r_slip":
                combo_list.Add(AllStrikes.AllDefence.r_slip);
                break;
            case "l_slip":
                combo_list.Add(AllStrikes.AllDefence.l_slip);
                break;
            case "pull":
                combo_list.Add(AllStrikes.AllDefence.pull);
                break;
            case "l_roll":
                combo_list.Add(AllStrikes.AllDefence.l_roll);
                break;
            case "r_roll":
                combo_list.Add(AllStrikes.AllDefence.r_roll);
                break;
            case "duck":
                combo_list.Add(AllStrikes.AllDefence.duck);
                break;
            case "l_catch":
                combo_list.Add(AllStrikes.AllDefence.l_catch);
                break;

            case "r_catch":
                combo_list.Add(AllStrikes.AllDefence.r_catch);
                break;

            case "l_parry":
                combo_list.Add(AllStrikes.AllDefence.l_parry);
                break;
            case "r_parry":
                combo_list.Add(AllStrikes.AllDefence.r_parry);
                break;
            case "bodyblock":
                combo_list.Add(AllStrikes.AllDefence.bodyblock);
                break;
            case "r_bodyblock":
                combo_list.Add(AllStrikes.AllDefence.r_bodyblock);
                break;
            case "l_bodyblock":
                combo_list.Add(AllStrikes.AllDefence.l_bodyblock);
                break;
            case "s_roll":
                combo_list.Add(AllStrikes.AllDefence.s_roll);
                break;



        }
        ShowText();

    }

    private void OnPunchClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var param = button?.CommandParameter as string;

        if (param == null)
            return;

        switch (param)
        {
            case "jab":
                combo_list.Add(AllStrikes.jab);
                break;
            case "cross":
                combo_list.Add(AllStrikes.cross);
                break;
            case "lead_hook":
                combo_list.Add(AllStrikes.lead_hook);
                break;
            case "rear_hook":
                combo_list.Add(AllStrikes.rear_hook);
                break;
            case "lead_upper":
                combo_list.Add(AllStrikes.lead_upper);
                break;
            case "rear_upper":
                combo_list.Add(AllStrikes.rear_upper);
                break;
            case "jab_b":
                combo_list.Add(AllStrikes.jab_b);
                break;
            case "cross_b":
                combo_list.Add(AllStrikes.cross_b);
                break;
            case "lead_hook_b":
                combo_list.Add(AllStrikes.lead_hook_b);
                break;
            case "lead_upper_b":
                combo_list.Add(AllStrikes.lead_upper_b);
                break;
            case "rear_hook_b":
                combo_list.Add(AllStrikes.rear_hook_b);
                break;
            case "rear_upper_b":
                combo_list.Add(AllStrikes.rear_upper_b);
                break;


        }
        ShowText();

    }
    private void ShowText()
    {
        combo_label.Text = string.Join(", ", combo_list.Select(c => c.name));




    }
    async private void AddCombo(object sender, EventArgs e)
    {

        string text = WorkoutNameEntry.Text;


            own_workout.AddCombo(new ComboClass(combo_list, 3, 3, 3));
            ShowText();

            combo_list = new List<IStrike>(); // Nová instance seznamu
            combo_label.Text = "";





    }
    async private void SaveWorkout(object sender, EventArgs e)
    {

        own_workout.IsOwn = true;
      await SaveWorkout(own_workout);
    }
    public async Task<User> LoadUserProgressAsync()
    {
        var filePath = Path.Combine(FileSystem.AppDataDirectory, "UserProgress2.json");
        if (!File.Exists(filePath)) return new User(); // Defaultní data

        var json = await File.ReadAllTextAsync(filePath);
        return JsonSerializer.Deserialize<User>(json);
    }
    public async Task<WorkoutClass> LoadOwnWorkout()
    {
        var filePath = Path.Combine(FileSystem.AppDataDirectory, "OwnWorkout.json");

        // Zkontroluj, zda soubor vůbec existuje
        if (!File.Exists(filePath))
        {
            Console.WriteLine("File does not exist");
            return new WorkoutClass("own", new List<ComboClass>(), 0); // Vrať defaultní hodnotu
        }

        try
        {
            var json = await File.ReadAllTextAsync(filePath);
            return JsonSerializer.Deserialize<WorkoutClass>(json);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Chyba při načítání souboru: {ex.Message}");
            return new WorkoutClass("own", new List<ComboClass>(), 0); // Vrať defaultní hodnotu při chybě
        }
    }


    public async Task SaveWorkout(WorkoutClass workout)
    {
    
        string text = WorkoutNameEntry.Text;
        if (SpeedPicker.SelectedItem == null)

        {
            await DisplayAlert("Error", Trener.Resources.Languages.objectsStrings.speedMessage, "OK");
            return;
        }

        if (string.IsNullOrEmpty(text))
        {
            // Pokud uživatel nezadal jméno workoutu, zobrazíme upozornění
            await DisplayAlert("Error",Trener.Resources.Languages.objectsStrings.nameMessage, "OK");
            return;
        }
        if (workout.Combos == null || !workout.Combos.Any())
        {
            await DisplayAlert("Error", Trener.Resources.Languages.objectsStrings.emptyWorkoutError, "OK");
            return;
        }
        // Serializujeme seznam workoutů
        var json = JsonSerializer.Serialize(workout, new JsonSerializerOptions { WriteIndented = true });
        string validFileName = string.Concat(text.Split(Path.GetInvalidFileNameChars()));

        // Vytvoření cesty k souboru s dynamickým názvem
        var filePath = Path.Combine(FileSystem.AppDataDirectory, validFileName + ".json"); await File.WriteAllTextAsync(filePath, json);
        SaveUserNameToCsv(text);
        ReopenPage();

    }
    public async void ReopenPage()
    {
        own_workout = new WorkoutClass();

        await Application.Current.MainPage.Navigation.PopAsync();
        await Application.Current.MainPage.Navigation.PushAsync(new MakeYourOwnPage());


    }
    public async void DeleteCurWorkout(object sender, EventArgs e)
    {
        ReopenPage();
    }

    public async void  StartWorkout(object sender, EventArgs e)
    {

        WorkoutClass ow = await LoadOwnWorkout();
        await Application.Current.MainPage.Navigation.PushAsync(new ActionPage(ow));

    }

    public async void ShowWorkout(object sender, EventArgs e)
    {

        await Application.Current.MainPage.Navigation.PushAsync(new ShowOwnWorkout(own_workout));



    }
    public async void ViewWorkouts(object sender, EventArgs e)
    {

        WorkoutClass ow = await LoadOwnWorkout();
        await Application.Current.MainPage.Navigation.PushAsync(new ViewOwnWorkouts());



    }
    public async void DeleteCombo(object sender, EventArgs e)
    {
        combo_label.Text = "";
        combo_list.Clear();
    }
    public static void SaveUserNameToCsv( string name)
    {
        try
        {
            string filePath = Path.Combine(FileSystem.AppDataDirectory, "names.csv");

            // Otevřeme soubor pro přidání textu
            using (StreamWriter sw = new StreamWriter(filePath, append: true))
            {
                sw.WriteLine($"{name},"); // Oddělení hodnot čárkou, což je formát pro CSV
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Došlo k chybě při zápisu do souboru: {ex.Message}");
        }
    }


}