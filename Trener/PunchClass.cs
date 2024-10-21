using Plugin.Maui.Audio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;



namespace Trener
{
    public class PunchClass: IStrike
    {
        public int id;
        public string name;
        public string sound;


        public PunchClass(int id,string name, string sound)
        {
            this.id= id;
            this.name= name;
            this.sound= sound;
        }

        string IStrike.id { get => id.ToString(); set => id = int.Parse(value); }
        string IStrike.name { get => name; set => name = value; }
        string IStrike.sound { get => sound; set => sound = value; }
    }
    public class MoveClass : IStrike
    {
        public int id;
        public string name;
        public string sound;


        public MoveClass(int id, string name, string sound)
        {
            this.id = id;
            this.name = name;
            this.sound = sound;
        }

        string IStrike.id { get => id.ToString(); set => id = int.Parse(value); }
        string IStrike.name { get => name; set => name = value; }
        string IStrike.sound { get => sound; set => sound = value; }
    }
    public class DefenceClass : IStrike
    {
        public int id;
        public string name;
        public string sound;

        string IStrike.id { get => id.ToString(); set => id = int.Parse(value); }
        string IStrike.name { get => name; set => name = value; }
        string IStrike.sound { get => sound; set => sound = value; }
        public DefenceClass(int id, string name, string sound)
        {
            this.id = id;
            this.name = name;
            this.sound = sound;
        }


    }
    public class AdviceClass: IStrike
    {
        public int id;
        public string name;
        public string sound;

        string IStrike.id { get => id.ToString(); set => id = int.Parse(value); }
        string IStrike.name { get => name; set => name = value; }
        string IStrike.sound { get => sound; set => sound = value; }
        public AdviceClass(int id, string name, string sound)
        {
            this.id = id;
            this.name = name;
            this.sound = sound;
        }
    }
    public class ExerciseClass : IStrike
    {
        public int id;
        public string name;
        public string sound;

        string IStrike.id { get => id.ToString(); set => id = int.Parse(value); }
        string IStrike.name { get => name; set => name = value; }
        string IStrike.sound { get => sound; set => sound = value; }

        public ExerciseClass(int id, string name, string sound)
        {
            this.id = id;
            this.name = name;
            this.sound = sound;
        }


    }

    public class ComboClass
    {
        public List<IStrike> strikes = new List<IStrike>();
        public string name;
        public int reps;
        public int time;
        public int intro_time;
        public int type;
        public int id;
        public int exercise_time;

        public ComboClass(List<IStrike> strikes, int reps,int time, int intro_time)
        {
            this.strikes = strikes;
            this.time = time;
            this.reps = reps;
            this.intro_time= intro_time;
        }

        public ComboClass(List<IStrike> strikes,int exercise_time)
        {
            this.strikes = strikes;
            this.exercise_time = exercise_time;
    
        }

        public List<IStrike> GetStrikes() { 
           return strikes;

        }
        public string GetName()
        {
            string name1 = "";
            for (int i = 0; i < strikes.Count; i++)
            {
                name1 += strikes[i].name;
                if(i == strikes.Count - 1 || strikes.Count==1)
                {

                }
                else
                {
                    name1 += "-";

                }

            }
            return name1;

        }
        public async Task PlaySound()
        {
            for (int i = 0; i < strikes.Count; i++)
            {
                var audioPlayer = AudioManager.Current.CreatePlayer(await FileSystem.OpenAppPackageFileAsync(strikes[i].sound));

                var tcs = new TaskCompletionSource<bool>();

                // Subscribe to the PlaybackEnded event
                audioPlayer.PlaybackEnded += (sender, e) =>
                {
                    tcs.TrySetResult(true); // Mark the task as complete when playback ends
                };

                // Play the sound
                audioPlayer.Play();

                // Wait for the playback to finish
                await ((tcs.Task));

                // Wait an additional 600ms before playing the next sound
                //await Task.Delay(000);
            }

            // Optional: Wait an additional 200ms after all sounds have played
            await Task.Delay(intro_time);
        }

        public int GetNumOfStrikes() { 

            return strikes.Count;
        }


      


    }
    public class WorkoutClass
    {
        public List<ComboClass> combos = new List<ComboClass>();
        public int num_of_rounds;
        public int id;

        public WorkoutClass(List <ComboClass> combos,int num_of_rounds)
        {
            this.combos = combos;
            this.num_of_rounds = num_of_rounds;
        }
      
        public int TotalNumOfCombos()
        {
            return combos.Count;
        }

    }
    public class FitnessWorkoutClass : WorkoutClass
    {
        public int break_time;
        public int work_time;


        public FitnessWorkoutClass(List<ComboClass> combos, int num_of_rounds, int work_time, int break_time) : base(combos, num_of_rounds)
        {
            this.break_time = break_time;
            this.work_time = work_time;
        }
    }
}
