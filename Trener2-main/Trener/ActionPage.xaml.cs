using System.Diagnostics;
using Microsoft.Maui.Storage;
using Plugin.Maui.Audio;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Maui.Dispatching;
using System.Text.Json;
using System.Dynamic;

namespace Trener
{
    public partial class ActionPage : ContentPage
    {
        private WorkoutClass workout;
        private bool stopped;
        private bool paused;
        private bool skipped;
        private Stopwatch timer = new Stopwatch();
        private bool end;
        private CancellationTokenSource cts;
        User user2 = new();
        private int speed;

        public ActionPage(WorkoutClass workout)
        {
            this.speed = workout.speed;  
            this.workout = workout;
            InitializeComponent();
            Shell.SetNavBarIsVisible(this, false);

            Action();

        }



        async public void Action()
        {


            cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;
            int currentComIndex = 0;

            // Zobrazení času na pozadí
            _ = Task.Run(() => ShowTime(token));

            try
            {

                skipped = false;

                await Task.Delay(1000, token);
                await GenericSounds.PlayGetReadySound(token);
                await Task.Delay(1000, token);






                while (!end && !token.IsCancellationRequested)
                {
                    // Pozastavení běhu, pokud je aktivní pauza
                    await CheckPauseAsync(token);




                    ComboClass combo = workout.Combos[currentComIndex];
                    bool isAdvice = combo.Strikes[0] is AdviceClass;

                    UpdateCountLabel(currentComIndex, workout.Combos.Count);
                    UpdateComboLabelFontSize(combo.Name.Length);

                    combo_label.Text = combo.Name;

                   
                    UpdateStrikeLabelBackground(isAdvice);

                    await PlaySoundAsync(combo, token);
                    await Task.Delay(100, token);

                    await ExecuteCombo(speed, combo, isAdvice, token);

                    currentComIndex++;
                    if (currentComIndex == workout.TotalNumOfCombos())
                    {
                        if (workout.IsOwn)
                        {
                            user2.AddToList(new FinishedWorkout(workout.Id, DateTime.Now, true));

                        }
                        else
                        {
                            user2.AddToList(new FinishedWorkout(workout.Id, DateTime.Now));

                        }

                        await user2.SaveUserProgressAsync(user2);  // Zavolání metody pro uložení


                        await Application.Current.MainPage.Navigation.PushAsync(new EndOfWorkoutPage());

                        end = true;
                    }







                    skipped = false;
                }
            }
            catch (TaskCanceledException)
            {
                // Log or handle the cancellation if needed
            }
            finally
            {
                cts.Dispose(); // Clean up the cancellation token source
            }
        }

        private void UpdateCountLabel(int index, int totalCombos)
        {
            ChangeTextOnLabel(count_label, $"{index + 1}/{totalCombos}");

        }

        private async Task CheckPauseAsync(CancellationToken token)
        {


            await Task.Run(async () =>
            {
                while (paused && !token.IsCancellationRequested)
                {
                    await Task.Delay(500); // Kontroluje pauzu každých 500ms
                }
            });
        }


        private void UpdateComboLabelFontSize(int comboLength)
        {
            if (comboLength > 15)
            {
                combo_label.FontSize = 24;
            }
            else if( comboLength > 11) {
                combo_label.FontSize = 30;
            }
            else
            {
                combo_label.FontSize = 52;
            }
        }


        private void UpdateStrikeLabelBackground(bool isAdvice)
        {
            strike_label.BackgroundColor = isAdvice ? Color.FromRgb(0, 255, 0) : Color.FromHex("#9370DB");
        }



        private async Task ExecuteCombo(int speed, ComboClass combo, bool isAdvice, CancellationToken token)
        {

            int currentRep = 0;
            int adjKTime = Convert.ToInt32(Math.Round((double)combo.Time / 1));

            for (int i = 0; i < combo.Reps; i++)
            {
                await CheckPauseAsync(token); // Check pause before each iteration
                if (token.IsCancellationRequested) return;

                currentRep++;
                if (!isAdvice && !skipped)
                {
                    ChangeTextOnLabel(rep_label, $"{currentRep}/{combo.Reps}");

                    strike_label.BackgroundColor = Color.FromRgb(255, 0, 0);
                    await PlaySoundSequentially(GenericSounds.PlayGoSound, token);
                }

                await ExecuteStrikes(speed, combo.Strikes, isAdvice, token);

                if (!isAdvice) await Task.Delay(200, token);
            }
        }
        private async Task ExecuteStrikes(int speed, List<IStrike> currentStrikes, bool isAdvice, CancellationToken token)
        {
            // Proměnná pro sledování aktuální barvy

            foreach (var strike in currentStrikes)
            {
                ChangeTextOnLabel(strike_label, strike.id);

                if (!isAdvice && !skipped)
                {
                    // Střídání barvy: pokud je isRed true, nastavíme červenou, jinak žlutou
                    if (strike is PunchClass)
                    {
                        strike_label.BackgroundColor = Color.FromRgb(255, 0, 0);
                    }
                    else if (strike is DefenceClass)
                    {
                        strike_label.BackgroundColor = Color.FromRgb(173, 216, 230);

                    }
                    else
                    {
                        strike_label.BackgroundColor = Color.FromRgb(144, 238, 144);

                    }


                    await Task.Delay(speed, token); // Zpoždění mezi údery

                }

                ChangeTextOnLabel(strike_label, " ");
                strike_label.BackgroundColor = Color.FromHex("#9370DB");


            }
        }





        private async Task PlaySoundAsync(ComboClass combo, CancellationToken token)
        {
            await combo.PlaySound(token);
        }

        private void SkipFunc(object sender, EventArgs e)
        {
            skipped = true;
        }


        private void StopFunc(object sender, EventArgs e)
        {
            paused = !paused;
        }

        private async void EndFunc(object sender, EventArgs e)
        {
            end = true;
            cts.Cancel();

            await Application.Current.MainPage.Navigation.PopToRootAsync(); // ✅ Vrátí se na hlavní stránku
        }

        private void ChangeTextOnLabel(Label label, string text)
        {
            MainThread.BeginInvokeOnMainThread(() =>
            {
                label.Text = text;
            });
        }
        private static readonly SemaphoreSlim soundLock = new SemaphoreSlim(1, 1);

        private async Task PlaySoundSequentially(Func<CancellationToken, Task> soundFunc, CancellationToken token)
        {
            await soundLock.WaitAsync(token); // Zajistí, že další zvuk se nezačne přehrávat dřív, než skončí ten předchozí
            try
            {
                await soundFunc(token);
            }
            finally
            {
                soundLock.Release(); // Uvolní zámek pro další zvuk
            }
        }

        public async Task<User> LoadUserProgressAsync()
        {
            var filePath = Path.Combine(FileSystem.AppDataDirectory, "UserProgress2.json");

            // Zkontrolujeme, zda soubor existuje
            if (!File.Exists(filePath))
            {
                return new User(); // Pokud soubor neexistuje, vrátíme nový prázdný objekt User
            }

            // Načteme JSON text ze souboru
            var json = await File.ReadAllTextAsync(filePath);

            // Deserializace JSON textu zpět do objektu User
            var user = JsonSerializer.Deserialize<User>(json);

            return user;
        }

        private async Task ShowTime(CancellationToken token)
        {
            await Task.Run(async () =>
            {
                while (!token.IsCancellationRequested)
                {
                    await Task.Delay(1000, token);
                    if (!paused && !stopped)
                    {
                        timer.Start();
                        TimeSpan ts = timer.Elapsed;
                        string elapsedTime = String.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds);

                        MainThread.BeginInvokeOnMainThread(() =>
                        {
                            time_label.Text = elapsedTime;
                        });
                    }
                    else
                    {
                        timer.Stop();
                    }
                }
            });
        }


    }
}
