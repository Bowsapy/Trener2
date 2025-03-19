using System.Diagnostics;
using Microsoft.Maui.Storage;
using Plugin.Maui.Audio;
using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Maui.Dispatching;
using Trener.Resources.Languages; // Namespace, kde jsou generované Resources


namespace Trener
{
    public partial class ActionPage2 : ContentPage
    {
        private FitnessWorkoutClass workout;
        private bool stopped;
        private bool end;
        private bool skipped;
        private Stopwatch timer = new Stopwatch();
        private CancellationTokenSource cts;
        User user2 = new User();



        public ActionPage2(FitnessWorkoutClass workout)
        {
            Shell.SetNavBarIsVisible(this, false);

            this.workout = workout;
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false); // Skryje horní lištu (toolbar)

            Action();
        }

 





        public async void Action()
        {
            cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;
            List<ComboClass> combos = workout.Combos;
            end = false;
            int index = 0;
            int currentRound = 0;

            try
            {
                await PlayGetReadyAsync(token);
                await Task.Delay(2000, token);

                while (index < combos.Count && !end)
                {
                    List<IStrike> combos2 = combos[index].Strikes;

                    ComboClass currentCombo = combos[index];
                    ChangeTextOnLabel(combo_label, currentCombo.Name);
                    UpdateNextRoundLabel(index, combos);

                    UpdateCountLabel(index, combos.Count);
                    SetFComboLabelFontSize(currentCombo.Name);                 

                                        await PlaySoundAsync(currentCombo, token);
                    SetComboLabelColor(Color.FromRgb(255, 0, 0));

                    await GenericSounds.PlayGoSound(token);
                    await StartTimerAsync(currentCombo.ExerciseTime + 1, token);
                
                    
                    await GenericSounds.PlayBreakSound(token);
                    SetComboLabelColor(Color.FromRgb(0, 255, 0));
                    await StartTimerAsync((workout.Getbreaktime())  * 5 + 1, token);

                    currentRound++;
                    index++;

                    if( index == combos.Count)
                    {
                        user2.AddToList(new FinishedWorkout(workout.Id, DateTime.Now));

                        await user2.SaveUserProgressAsync(user2);  // Zavolání metody pro uložení
                        await Application.Current.MainPage.Navigation.PushAsync(new EndOfWorkoutPage());
                        end = true;

                    }



                }
            }
            catch (TaskCanceledException)
            {
                // Task was canceled, no action needed if cancellation is intentional.
            }
            finally
            {
                cts.Dispose(); // Uvolni zdroj po skončení.
            }
        }

        private void SetFComboLabelFontSize(string combo)
        {
            int fontsize;
           fontsize  =(-2)* (combo.Length) + 95;
            
        }

        private async Task PlayGetReadyAsync(CancellationToken token)
        {
            await GenericSounds.PlayGetReadySound(token);
        }

        private void UpdateNextRoundLabel(int index, List<ComboClass> combos)
        {
            if (index + 1 < combos.Count)
            {
                ChangeTextOnLabel(nextR_label, (Trener.Resources.Languages.objectsStrings.nextRound + ": " + combos[index + 1].Name));
            }
            else
            {
                ChangeTextOnLabel(nextR_label, "-");
            }
        }
        private void UpdateCountLabel(int index, int totalCombos)
        {
            ChangeTextOnLabel(count_label, $"{index + 1}/{totalCombos}");
        
        }

        private void SetComboLabelColor(Color color)
        {
            combo_label.BackgroundColor = color;
        }

        private async Task PlaySoundAsync(ComboClass combo, CancellationToken token)
        {
            await combo.PlaySound(token);
        }

        private async Task StartTimerAsync(int seconds, CancellationToken token)
        {
            for (int i = 1; i <= seconds && !token.IsCancellationRequested; i++)
            {
                if (end) return;
                if (stopped) time_label.BackgroundColor = Color.FromRgb(128, 128, 128);

                while (stopped)
                {
                    await Task.Delay(1000, token);
                }

                time_label.BackgroundColor = Color.FromRgb(100, 0, 255);

                if (skipped)
                {
                    skipped = false;
                    break;
                }

                await Task.Delay(1000, token);

                MainThread.BeginInvokeOnMainThread(() =>
                {
                    time_label.Text = (seconds - i).ToString();
                });
            }
        }



        private void StopFunc(object sender, EventArgs e)
        {
            stopped = !stopped;
        }


        private void SkipniFunc(object sender, EventArgs e)
        {
            skipped = true;
        }



        private async void EndFunc(object sender, EventArgs e)
        {
            end = true;
            cts.Cancel();

     

            await Application.Current.MainPage.Navigation.PopToRootAsync(); // ✅ Vrátí se na hlavní stránku
        }

        private void ChangeTextOnLabel(Label label, string text)
        {
            label.Text = text;
        }
        private void UpdateComboLabelFontSize(int comboLength)
        {
            // Maximální a minimální velikost písma
            int maxFontSize = 150;
            int minFontSize = 20;

            // Dynamická změna fontu (například klesá s rostoucím comboLength)
            int fontSize = Math.Max(minFontSize, maxFontSize - comboLength * 5);

            combo_label.FontSize = fontSize;
        }


    }
}
