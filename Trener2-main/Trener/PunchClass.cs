using Plugin.Maui.Audio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;



namespace Trener
{
    public class PunchClass : IStrike
    {
        private string id;
        private string name;
        private string sound;


        public PunchClass(string id, string name, string sound)
        {
            this.id = id;
            this.name = name;
            this.sound = sound;
        }

        string IStrike.id { get => id.ToString(); set => id = (value); }
        string IStrike.name { get => name; set => name = value; }
        string IStrike.sound { get => sound; set => sound = value; }
    }
    public class MoveClass : IStrike
    {
        private string id;
        private string name;
        private string sound;


        public MoveClass(string id, string name, string sound)
        {
            this.id = id;
            this.name = name;
            this.sound = sound;
        }

        string IStrike.id { get => id.ToString(); set => id = value; }
        string IStrike.name { get => name; set => name = value; }
        string IStrike.sound { get => sound; set => sound = value; }
    }
    public class DefenceClass : IStrike
    {
        private string id;
        private string name;
        private string sound;

        string IStrike.id { get => id.ToString(); set => id = value; }
        string IStrike.name { get => name; set => name = value; }
        string IStrike.sound { get => sound; set => sound = value; }
        public DefenceClass(string id, string name, string sound)
        {
            this.id = id;
            this.name = name;
            this.sound = sound;
        }


    }
    public class AdviceClass : IStrike
    {
        private string id = " ";
        private string name;
        private string sound;

        string IStrike.id { get => id.ToString(); set => id = value; }
        string IStrike.name { get => name; set => name = value; }
        string IStrike.sound { get => sound; set => sound = value; }
        public AdviceClass(string name, string sound)
        {
            this.id = id;
            this.name = name;
            this.sound = sound;
        }
    }
    public class ExerciseClass : IStrike
    {
        private string id;
        private string name;
        private string sound;

        string IStrike.id { get => id.ToString(); set => id = (value); }
        string IStrike.name { get => name; set => name = value; }
        string IStrike.sound { get => sound; set => sound = value; }

        public ExerciseClass(string id, string name, string sound)
        {
            this.id = id;
            this.name = name;
            this.sound = sound;
        }


    }

    public class ComboClass
    {
        private List<IStrike> strikes = new List<IStrike>();
        private string name;
        private int reps;
        private int time;
        private int intro_time;
        private int type;
        private int id;
        private int exercise_time;

        public ComboClass(List<IStrike> strikes, int reps, int time, int intro_time)
        {
            this.strikes = strikes;
            this.time = time;
            this.reps = reps;
            this.intro_time = intro_time;
        }

        public ComboClass(List<IStrike> strikes, int exercise_time)
        {
            this.strikes = strikes;
            this.exercise_time = exercise_time;

        }
        public int Getreps() { return reps; }
        public int Gettime() { return time; }
        public int GetType() { return type; }
        public int GetId() { return id; }
        public int GetExercise_time() { return exercise_time; }


        public List<IStrike> GetStrikes() {
            return strikes;

        }
        public string GetName()
        {
            string name1 = "";
            for (int i = 0; i < strikes.Count; i++)
            {
                name1 += strikes[i].name;
                if (i == strikes.Count - 1 || strikes.Count == 1)
                {

                }
                else
                {
                    name1 += "-";

                }

            }
            return name1;

        }
        public async Task PlaySound(CancellationToken token)
        {
            for (int i = 0; i < strikes.Count; i++)
            {
                // Zkontroluj, zda byl zrušen token
                if (token.IsCancellationRequested)
                    return;

                var audioPlayer = AudioManager.Current.CreatePlayer(await FileSystem.OpenAppPackageFileAsync(strikes[i].sound));
                var tcs = new TaskCompletionSource<bool>();

                // Připoj se k události PlaybackEnded
                audioPlayer.PlaybackEnded += (sender, e) =>
                {
                    tcs.TrySetResult(true); // Když přehrávání skončí, označ úkol jako dokončený
                };

                // Spusť zvuk
                audioPlayer.Play();

                // Čekej na dokončení přehrávání nebo zrušení
                await Task.WhenAny(tcs.Task, Task.Delay(Timeout.Infinite, token));

                // Pokud byl požadavek zrušen, zastav přehrávání a ukonči
                if (token.IsCancellationRequested)
                {
                    audioPlayer.Stop();
                    return;
                }

                // Po přehrání každého zvuku čekej další 600ms
                await Task.Delay(600, token);
            }

            // Pokud nebylo zrušeno, čekej dalších `intro_time` ms po přehrání všech zvuků
            if (!token.IsCancellationRequested)
            {
                await Task.Delay(intro_time, token);
            }
        }

        public int GetNumOfStrikes() {

            return strikes.Count;
        }





    }
    public class WorkoutClass
    {
        private List<ComboClass> combos = new List<ComboClass>();
        private int num_of_rounds;
        private string id;
       

        public WorkoutClass(string id, List<ComboClass> combos, int num_of_rounds)
        {
            this.combos = combos;
            this.num_of_rounds = num_of_rounds;
            this.id = id;
        }

        public string GetId()
        {
            return id;
        }
        public List<ComboClass> GetCombos()
        {
            return combos;
        }
        public int TotalNumOfCombos()
        {
            return combos.Count;
        }
        public int GetNumOfRounds()
        {
            return num_of_rounds;
        }


    }
    public class FitnessWorkoutClass : WorkoutClass
    {
        private int break_time;
        private int work_time;


        public FitnessWorkoutClass(string id, List<ComboClass> combos, int num_of_rounds, int work_time, int break_time) : base(id, combos, num_of_rounds)
        {
            this.break_time = break_time;
            this.work_time = work_time;
        }
        public int Getworktime()
        {
            return work_time;
        }
        public int Getbreaktime()
        {
            return break_time; }
     }
    
}
