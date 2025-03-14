﻿using Plugin.Maui.Audio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;



namespace Trener
{
    public class PunchClass : IStrike
    {
        public string id { get; set; }
        public string name { get; set; }
        public string sound { get; set; }
        public string type { get; set; } = "punch";  // Veřejná vlastnost


        [JsonConstructor]
        public PunchClass(string id, string name, string sound)
        {
            this.id = id;
            this.name = name;
            this.sound = sound;

        }

        string IStrike.id { get => id.ToString(); set => id = (value); }
        string IStrike.name { get => name; set => name = value; }
        string IStrike.sound { get => sound; set => sound = value; }
        string IStrike.type { get; set; } = "punch";

    }

    public class MoveClass : IStrike
    {
        public string id { get; set; }
        public string name { get; set; }
        public string sound { get; set; }
        public string type { get; set; } = "move";  // Veřejná vlastnost



        [JsonConstructor]

        public MoveClass(string id, string name, string sound)
        {
            this.id = id;
            this.name = name;
            this.sound = sound;
        }

        string IStrike.id { get => id.ToString(); set => id = value; }
        string IStrike.name { get => name; set => name = value; }
        string IStrike.sound { get => sound; set => sound = value; }
        string IStrike.type { get; set; } = "move";

    }
    public class DefenceClass : IStrike
    {
        public string id { get; set; }
        public string name { get; set; }
        public string sound { get; set; }
        public string type { get; set; } = "defence";  // Veřejná vlastnost




        string IStrike.id { get => id.ToString(); set => id = value; }
        string IStrike.name { get => name; set => name = value; }
        string IStrike.sound { get => sound; set => sound = value; }

        string IStrike.type { get; set; } = "defence";

        [JsonConstructor]

        public DefenceClass(string id, string name, string sound)
        {
            this.id = id;
            this.name = name;
            this.sound = sound;
        }


    }
    public class AdviceClass : IStrike
    {
        public string id { get; set; }
        public string name { get; set; }
        public string sound { get; set; }
        public string Type { get; set; } = "advice";


        string IStrike.name { get => name; set => name = value; }
        string IStrike.sound { get => sound; set => sound = value; }
        string IStrike.type { get; set; } = "advice";

        [JsonConstructor]

        public AdviceClass( string name, string sound)
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

        string IStrike.type { get; set; } = "exercise";


        public ExerciseClass(string id, string name, string sound)
        {
            this.id = id;
            this.name = name;
            this.sound = sound;
        }


    }


public class ComboClass
    {
        [JsonPropertyName("strikes")]
        [JsonConverter(typeof(IStrikeJsonConverter))]  // Použití konvertoru pro správnou deserializaci

        public List<IStrike> Strikes { get; set; } = new List<IStrike>();

        [JsonPropertyName("name")]
        public string Name => GenerateName();

        [JsonPropertyName("reps")]
        public int Reps { get; set; }

        [JsonPropertyName("time")]
        public int Time { get; set; }

        [JsonPropertyName("intro_time")]
        public int IntroTime { get; set; }

        [JsonPropertyName("type")]
        public int Type { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("exercise_time")]
        public int ExerciseTime { get; set; }

        public ComboClass(List<IStrike> strikes, int reps, int time, int introTime)
        {
            Strikes = strikes;
            Reps = reps;
            Time = time;
            IntroTime = introTime;
        }

        public ComboClass(List<IStrike> strikes, int exerciseTime)
        {

            Strikes = strikes;
            ExerciseTime = exerciseTime;
        }
        public ComboClass()
        {
 
        }

        private string GenerateName()
        {
            return string.Join("-", Strikes.ConvertAll(s => s.name));
        }

        public async Task PlaySound(CancellationToken token)
        {

            // Předem načteme všechny soubory a připravíme přehrávače
            var players = new List<IAudioPlayer>();

            try
            {
                foreach (var strike in Strikes)
                {
                    if (token.IsCancellationRequested)
                        return;

                    var fileStream = await FileSystem.OpenAppPackageFileAsync(strike.sound);
                    var audioPlayer = AudioManager.Current.CreatePlayer(fileStream);
                    players.Add(audioPlayer);
                }

                // Přehráváme zvuky sekvenčně s minimální prodlevou
                foreach (var player in players)
                {
                    if (token.IsCancellationRequested)
                        return;

                    var tcs = new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously);

                    void OnPlaybackEnded(object? sender, EventArgs e) => tcs.TrySetResult(true);
                    player.PlaybackEnded += OnPlaybackEnded;

                    player.Play();

                    await Task.WhenAny(tcs.Task, Task.Delay(Timeout.Infinite, token));

                    player.PlaybackEnded -= OnPlaybackEnded;

                    if (token.IsCancellationRequested)
                    {
                        player.Stop();
                        return;
                    }

                    // Zkrácená pauza mezi zvuky (např. 100 ms místo 200 ms)
                }
            }
            finally
            {
                // Uvolníme všechny přehrávače
                foreach (var player in players)
                {
                    player.Dispose();
                }
            }

            // Po skončení všech zvuků pauza (IntroTime)
            if (!token.IsCancellationRequested)
            {
                await Task.Delay(IntroTime, token);
            }




        }

        public int GetNumOfStrikes()
        {
            return Strikes.Count;
        }
    }

    public static class AllWorkoutClassCounter
    {
        private static int count = 20;
        public static void Add()
        {
        }
        public static int GetCount()
        {
            return count;
        }

    }


public class WorkoutClass
    {
        public List<ComboClass> Combos { get; set; } = new List<ComboClass>();
        public int NumOfRounds { get; set; }
        public string Id { get; set; }
        public int speed { get; set; }

        public bool IsOwn { get; set; }
        
        public WorkoutClass() { }

        public WorkoutClass(string id, List<ComboClass> combos, int numOfRounds,int Speed=500)
        {
            Combos = combos;
            NumOfRounds = numOfRounds;
            Id = id;
            speed = Speed;

        }

        public void AddCombo(ComboClass combo)
        {
            Combos.Add(combo);
        }

        public int TotalNumOfCombos()
        {
            return Combos.Count;
        }
    }

  


    public class FitnessWorkoutClass : WorkoutClass
    {
        private int break_time;
        private int work_time;

        public FitnessWorkoutClass(string id, List<ComboClass> combos, int num_of_rounds, int work_time, int break_time,int speed=400) : base(id, combos, num_of_rounds)
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
