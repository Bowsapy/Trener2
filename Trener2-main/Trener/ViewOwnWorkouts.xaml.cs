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
            LoadWorkoutButtons();  // Zavolání metody pro vytvoøení tlaèítek pøi startu
        }

        // Naète obsah CSV souboru (volitelné, pokud chcete pouít)
        public void LoadFileContent()
        {
            string filePath = Path.Combine(FileSystem.AppDataDirectory, "names.csv");

            if (File.Exists(filePath))
            {
                // Naètení celého obsahu souboru jako text
                string fileContent = File.ReadAllText(filePath);
                Console.WriteLine(fileContent);  // Zobrazení obsahu souboru v konzoli
            }
            else
            {
                Console.WriteLine("Soubor neexistuje.");
            }
        }

        // Tato metoda vytvoøí tlaèítka pro kadı název workoutu ze souboru
        public void LoadWorkoutButtons()
        {
            string filePath = Path.Combine(FileSystem.AppDataDirectory, "names.csv");

            // Naètìte soubor, pokud existuje
            if (File.Exists(filePath))
            {
                // Naètìte všechny øádky CSV souboru
                var lines = File.ReadAllLines(filePath);

                // Pro kadı název ve souboru vytvoøte tlaèítko
                foreach (var line in lines)
                {
                    if (!string.IsNullOrWhiteSpace(line)) // Pøeskoète prázdné øádky
                    {
                        // Vytvoøení tlaèítka
                        var button = new Button
                        {
                            Text = line,  // Text tlaèítka je název workoutu
                            VerticalOptions = LayoutOptions.CenterAndExpand,
                            HorizontalOptions = LayoutOptions.CenterAndExpand,
                            CommandParameter = line // Pøedáme parametr tlaèítku

                        };

                        // Pøiøazení klikací události
                        button.Clicked += async (sender, e) =>
                        {
                            var clickedButton = sender as Button; // Získání tlaèítka, které bylo kliknuto
                            if (clickedButton != null)
                            {
                                await StartWorkout(clickedButton); // Pøedání celého tlaèítka metodì StartWorkout
                            }
                        };

                        // Pøidání tlaèítka do rozvrení (StackLayout)
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

            // Naète workout data
            WorkoutClass ow = await LoadOwnWorkout(button.Text);
            // Naviguje na stránku pro workout
            await Application.Current.MainPage.Navigation.PushAsync(new ActionPage(ow));
        }

        // Naète workout z JSON souboru
        public async Task<WorkoutClass> LoadOwnWorkout(string name)
        {
            Debug.WriteLine(name);
            string result = name.Substring(0, name.Length - 1); // Od 0 do délky mínus 1

            var filePath = Path.Combine(FileSystem.AppDataDirectory, result + ".json");

            // Pokud soubor neexistuje, vra vıchozí instanci WorkoutClass
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Workout soubor neexistuje.");
                return new WorkoutClass();  // Pokud soubor neexistuje, vracíme prázdnou instanci
            }

            // Naète obsah souboru a deserializuje JSON do objektu WorkoutClass
            var json = await File.ReadAllTextAsync(filePath);
            return JsonSerializer.Deserialize<WorkoutClass>(json);
        }
    }
}
