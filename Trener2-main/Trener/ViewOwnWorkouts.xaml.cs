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
            LoadWorkoutButtons();  // Zavol�n� metody pro vytvo�en� tla��tek p�i startu
        }

        // Na�te obsah CSV souboru (voliteln�, pokud chcete pou��t)
        public void LoadFileContent()
        {
            string filePath = Path.Combine(FileSystem.AppDataDirectory, "names.csv");

            if (File.Exists(filePath))
            {
                // Na�ten� cel�ho obsahu souboru jako text
                string fileContent = File.ReadAllText(filePath);
                Console.WriteLine(fileContent);  // Zobrazen� obsahu souboru v konzoli
            }
            else
            {
                Console.WriteLine("Soubor neexistuje.");
            }
        }

        // Tato metoda vytvo�� tla��tka pro ka�d� n�zev workoutu ze souboru
        public void LoadWorkoutButtons()
        {
            string filePath = Path.Combine(FileSystem.AppDataDirectory, "names.csv");

            // Na�t�te soubor, pokud existuje
            if (File.Exists(filePath))
            {
                // Na�t�te v�echny ��dky CSV souboru
                var lines = File.ReadAllLines(filePath);

                // Pro ka�d� n�zev ve souboru vytvo�te tla��tko
                foreach (var line in lines)
                {
                    if (!string.IsNullOrWhiteSpace(line)) // P�esko�te pr�zdn� ��dky
                    {
                        // Vytvo�en� tla��tka
                        var button = new Button
                        {
                            Text = line,  // Text tla��tka je n�zev workoutu
                            VerticalOptions = LayoutOptions.CenterAndExpand,
                            HorizontalOptions = LayoutOptions.CenterAndExpand,
                            CommandParameter = line // P�ed�me parametr tla��tku

                        };

                        // P�i�azen� klikac� ud�losti
                        button.Clicked += async (sender, e) =>
                        {
                            var clickedButton = sender as Button; // Z�sk�n� tla��tka, kter� bylo kliknuto
                            if (clickedButton != null)
                            {
                                await StartWorkout(clickedButton); // P�ed�n� cel�ho tla��tka metod� StartWorkout
                            }
                        };

                        // P�id�n� tla��tka do rozvr�en� (StackLayout)
                        WorkoutButtonsStackLayout.Children.Add(button);
                    }
                }
            }
            else
            {
                Console.WriteLine("Soubor neexistuje.");
            }
        }

        // Tato metoda spust� workout
        public async Task StartWorkout(Button button)
        {

            // Na�te workout data
            WorkoutClass ow = await LoadOwnWorkout(button.Text);
            // Naviguje na str�nku pro workout
            await Application.Current.MainPage.Navigation.PushAsync(new ActionPage(ow));
        }

        // Na�te workout z JSON souboru
        public async Task<WorkoutClass> LoadOwnWorkout(string name)
        {
            Debug.WriteLine(name);
            string result = name.Substring(0, name.Length - 1); // Od 0 do d�lky m�nus 1

            var filePath = Path.Combine(FileSystem.AppDataDirectory, result + ".json");

            // Pokud soubor neexistuje, vra� v�choz� instanci WorkoutClass
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Workout soubor neexistuje.");
                return new WorkoutClass();  // Pokud soubor neexistuje, vrac�me pr�zdnou instanci
            }

            // Na�te obsah souboru a deserializuje JSON do objektu WorkoutClass
            var json = await File.ReadAllTextAsync(filePath);
            return JsonSerializer.Deserialize<WorkoutClass>(json);
        }
    }
}
