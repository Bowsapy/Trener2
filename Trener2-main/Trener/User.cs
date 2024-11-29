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

        public User()
        {
           
            this.fin_workouts = fin_workouts;
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
        public async void ShowProgress()
        {
          
        }

    }
}
