using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Trener
{
    public class User
    {
        public string Name { get; set; } = "Honza";
        public string Surname { get; set; } = "Bouza";

        [JsonInclude]
        public List <FinishedWorkout> fin_workouts= new List<FinishedWorkout>();
        public List<ComboClass> own_workout = new List<ComboClass>();


        int fin_workouts_done;


        public User()
        {
           
            this.fin_workouts = fin_workouts;
        }

        public int CountUniqueWorkouts()
        {
            List<FinishedWorkout> workouts = fin_workouts;
            List<FinishedWorkout> uniqueWorkouts = new List<FinishedWorkout>();

            foreach (var workout in workouts)
            {
                // Pokud seznam uniqueWorkouts neobsahuje stejné jméno cvičení, přidáme jej
                if (!uniqueWorkouts.Any(w => w.workoutName == workout.workoutName))
                {
                    uniqueWorkouts.Add(workout);
                }
            }

            // Return the count of unique workouts
            return uniqueWorkouts.Count;
        }

        public void AddToList(FinishedWorkout finishedWorkout)
        {
            fin_workouts.Add(finishedWorkout);
        }
        public List<FinishedWorkout> GetAllWorkouts()
        {
            return fin_workouts;
         }

        public async Task SaveUserProgressAsync(User progress)
        {
            var user = await LoadUserProgressAsync();

            // Přidáme nové workouty z aktuální instance
            user.fin_workouts.AddRange(this.fin_workouts);

            // Uložíme zpět celý seznam
            var json = JsonSerializer.Serialize(user, new JsonSerializerOptions { WriteIndented = true });
            var filePath = Path.Combine(FileSystem.AppDataDirectory, "UserProgress2.json");
            await File.WriteAllTextAsync(filePath, json);
        }

        //nacita progress
        public async Task<User> LoadUserProgressAsync()
        {
            var filePath = Path.Combine(FileSystem.AppDataDirectory, "UserProgress2.json");
            if (!File.Exists(filePath)) return new User(); // Defaultní data

            var json = await File.ReadAllTextAsync(filePath);
            return JsonSerializer.Deserialize<User>(json);
        }
        
    }
}
