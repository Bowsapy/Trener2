using Microsoft.Maui.Controls;
using System;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Trener
{
    public partial class ViewOwnWorkouts : ContentPage
    {
        public ViewOwnWorkouts()
        {
            InitializeComponent();
            LoadWorkoutButtons();  // Zavolání metody pro vytvoření tlačítek při startu
        }

        // Načte obsah CSV souboru (volitelné, pokud chcete použít)
        public void LoadFileContent()
        {
            string filePath = Path.Combine(FileSystem.AppDataDirectory, "names.csv");

            if (File.Exists(filePath))
            {
                // Načtení celého obsahu souboru jako text
                string fileContent = File.ReadAllText(filePath);
                Console.WriteLine(fileContent);  // Zobrazení obsahu souboru v konzoli
            }
            else
            {
                Console.WriteLine("Soubor neexistuje.");
            }
        }

        // Tato metoda vytvoří tlačítka pro každý název workoutu ze souboru
        public void LoadWorkoutButtons()
        {
            string filePath = Path.Combine(FileSystem.AppDataDirectory, "names.csv");

            // Načtěte soubor, pokud existuje
            if (File.Exists(filePath))
            {
                // Načtěte všechny řádky CSV souboru
                var lines = File.ReadAllLines(filePath);

                // Pro každý název ve souboru vytvořte tlačítko
                foreach (var line in lines)
                {
                    if (!string.IsNullOrWhiteSpace(line)) // Přeskočte prázdné řádky
                    {
                        // Vytvoření tlačítka
                        var button = new Button
                        {
                            Text = line,  // Text tlačítka je název workoutu
                            VerticalOptions = LayoutOptions.CenterAndExpand,
                            HorizontalOptions = LayoutOptions.CenterAndExpand,
                            CommandParameter = line, // Předáme parametr tlačítku
                            Margin = new Thickness(0, 10, 0, 0), // Opravená syntaxe
                                FontSize = 20 // Nastavení velikosti textu

                        };

                        // Přiřazení klikací události
                        button.Clicked += async (sender, e) =>
                        {
                            var clickedButton = sender as Button; // Získání tlačítka, které bylo kliknuto
                            if (clickedButton != null)
                            {
                                await StartWorkout(clickedButton); // Předání celého tlačítka metodě StartWorkout
                            }
                        };

                        // Přidání tlačítka do rozvržení (StackLayout)
                        WorkoutButtonsStackLayout.Children.Add(button);
                    }
                }
            }
            else
            {
                Console.WriteLine("Soubor neexistuje.");
            }
        }

        // Tato metoda spustí workout
        public async Task StartWorkout(Button button)
        {

            // Načte workout data
            WorkoutClass ow = await LoadOwnWorkout(button.Text);
            // Naviguje na stránku pro workout
            await Application.Current.MainPage.Navigation.PushAsync(new ActionPage(ow));
        }

        // Načte workout z JSON souboru
        public async Task<WorkoutClass> LoadOwnWorkout(string name)
        {
            Debug.WriteLine(name);
            string result = name.Substring(0, name.Length - 1); // Od 0 do délky mínus 1

            var filePath = Path.Combine(FileSystem.AppDataDirectory, result + ".json");

            // Pokud soubor neexistuje, vrať výchozí instanci WorkoutClass
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Workout soubor neexistuje.");
                return new WorkoutClass();  // Pokud soubor neexistuje, vracíme prázdnou instanci
            }

            // Načte obsah souboru a deserializuje JSON do objektu WorkoutClass
            var json = await File.ReadAllTextAsync(filePath);
            return JsonSerializer.Deserialize<WorkoutClass>(json);
        }
    }
}
