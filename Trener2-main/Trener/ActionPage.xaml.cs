using System.Diagnostics;
using Microsoft.Maui.Storage;
using Plugin.Maui.Audio;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Maui.Dispatching;
using System.Text.Json;

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
        User user2 = new User();
        
        public ActionPage(WorkoutClass workout)
        {
            this.workout = workout;
            InitializeComponent();
            Action();
        }

        public void OnBackButtonClicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new Tech1Page());
        }

        async public void Action()
        {




            user2.AddToList(new FinishedWorkout(workout.GetId(), DateTime.Now));

            await user2.SaveUserProgressAsync(user2);  // Zavol�n� metody pro ulo�en�

            cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;
            int currentComIndex = 0;
            //int remainingRounds = workout.GetNumOfRounds();
            int remainingRounds = 1;
            int currentRound = 1;
            double divisor = 1;

            // Zobrazen� �asu na pozad�
            _ = Task.Run(() => ZobrazCas(token));

            try
            {

                skipped = false;

                await Task.Delay(2000, token);
                await GenericSounds.PlayGetReadySound(token);
                await Task.Delay(2000, token);



                while (!end && !token.IsCancellationRequested)
                {
                    // Pozastaven� b�hu, pokud je aktivn� pauza
                    await CheckPauseAsync(token);

                 


                    UpdateRoundAndComboLabels(currentRound, currentComIndex);
                    ComboClass combo = workout.GetCombos()[currentComIndex];
                    bool isAdvice = combo.GetStrikes()[0] is AdviceClass;

                    combo_label.Text = combo.GetName();

                    UpdateComboLabelFontSize(combo.GetName().Length);
                    UpdateStrikeLabelBackground(isAdvice);

                    await PlaySoundAsync(combo, token);
                    await Task.Delay(200, token);

                    // Start executing the combo
                    await ExecuteCombo(combo, isAdvice, token);
                    
                    currentComIndex++;
                    if (currentComIndex == workout.TotalNumOfCombos())
                    {
                        currentComIndex = 0;
                        remainingRounds--;
                        currentRound++;
                        divisor *= 1.5;
                    }

                    if (remainingRounds == 0)
                    {
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

        private async Task CheckPauseAsync(CancellationToken token)
        {
            
        
            await Task.Run(async () =>
            {
                while (paused && !token.IsCancellationRequested)
                {
                    await Task.Delay(500); // Kontroluje pauzu ka�d�ch 500ms
                }
            });
        }


        private void UpdateRoundAndComboLabels(int currentRound, int currentComIndex)
        {
            ChangeTextOnLabel(round_label, $"{currentRound}/{workout.GetNumOfRounds()}");
            ChangeTextOnLabel(count_label, $"{currentComIndex + 1}/{workout.GetCombos().Count}");
        }

        private void UpdateComboLabelFontSize(int comboLength)
        {
            int fontSize = comboLength > 8 ? 50 : comboLength > 4 ? 80 : 100;
            combo_label.FontSize = fontSize;
        }

        private void UpdateStrikeLabelBackground(bool isAdvice)
        {
            strike_label.BackgroundColor = isAdvice ? Color.FromRgb(0, 255, 0) : Color.FromHex("#9D00FF");
        }



        private async Task ExecuteCombo(ComboClass combo, bool isAdvice, CancellationToken token)
        {
            int currentRep = 0;
            int adjKTime = Convert.ToInt32(Math.Round((double)combo.Gettime() / 1));

            for (int i = 0; i < combo.Getreps(); i++)
            {
                await CheckPauseAsync(token); // Check pause before each iteration
                if (token.IsCancellationRequested) return;

                currentRep++;
                if (!isAdvice)
                {
                    strike_label.BackgroundColor = Color.FromRgb(255, 0, 0);
                    await GenericSounds.PlayGoSound(token);
                }

                await Task.Delay(300, token);
                ChangeTextOnLabel(rep_label, $"{currentRep}/{combo.Getreps()}");
                await Task.Run(() => ExecuteStrikes(combo.GetStrikes(), isAdvice, token));

                if (!isAdvice) await Task.Delay(1200, token);
            }
        }

        private async Task ExecuteStrikes(List<IStrike> currentStrikes, bool isAdvice, CancellationToken token)
        {
            foreach (var strike in currentStrikes)
            {
                ChangeTextOnLabel(strike_label,strike.id);
                await CheckPauseAsync(token); // Kontrola pauzy

                if (end || skipped || token.IsCancellationRequested) break;

                await StopAll(token);
                if (!skipped)
                {
                    // P��m� vol�n� metod bez zbyte�n�ho vytv��en� nov�ch �loh.
                    switch (strike)
                    {
                        case PunchClass _:

                            await GenericSounds.PlayPunchSound2(token);
                            break;
                        case DefenceClass _:
                            await Task.Delay(50, token);
                            await GenericSounds.PlayDefenceSound(token);
                            break;
                        case MoveClass _:
                            await Task.Delay(200, token);
                            await GenericSounds.PlayMoveSound(token);
                            break;
                    }
                    Thread.Sleep(400);
                }

            }
            ChangeTextOnLabel(strike_label, "");

        }



        private async Task PlaySoundAsync(ComboClass combo, CancellationToken token)
        {
            await combo.PlaySound(token);
        }

        private void SkipniFunc(object sender, EventArgs e)
        {
            skipped = true;
        }

        private async Task StopAll(CancellationToken token)
        {
            while (stopped && !token.IsCancellationRequested)
            {
                await Task.Delay(1000, token);
            }
        }

        private void StopFunc(object sender, EventArgs e)
        {
            paused = !paused;
        }

        private async void EndFunc(object sender, EventArgs e)
        {
            end = true;
            cts.Cancel();

            await Application.Current.MainPage.Navigation.PopAsync();
            await Application.Current.MainPage.Navigation.PushAsync(new TechPage());
        }

        private void ChangeTextOnLabel(Label label, string text)
        {
            MainThread.BeginInvokeOnMainThread(() =>
            {
                label.Text = text;
            });
            }
        public async Task<User> LoadUserProgressAsync()
        {
            var filePath = Path.Combine(FileSystem.AppDataDirectory, "UserProgress2.json");

            // Zkontrolujeme, zda soubor existuje
            if (!File.Exists(filePath))
            {
                return new User(); // Pokud soubor neexistuje, vr�t�me nov� pr�zdn� objekt User
            }

            // Na�teme JSON text ze souboru
            var json = await File.ReadAllTextAsync(filePath);

            // Deserializace JSON textu zp�t do objektu User
            var user = JsonSerializer.Deserialize<User>(json);

            return user;
        }

        private async Task ZobrazCas(CancellationToken token)
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
