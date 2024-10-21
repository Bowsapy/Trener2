using System.Diagnostics;
using Microsoft.Maui.Storage;
using Plugin.Maui.Audio;
using System;
using System.Threading.Tasks;
using Microsoft.Maui.Dispatching;

namespace Trener
{
    public partial class ActionPage2 : ContentPage
    {
        FitnessWorkoutClass workout;
        bool stopped;
        bool end;
        Stopwatch timer = new Stopwatch();
        bool skipped;

        public ActionPage2(FitnessWorkoutClass workout)
        {
            this.workout = workout;
            InitializeComponent();
            Action();
        }

        public void OnBackButtonClicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new BegiPage2());
        }

        async public void Action()
        {
            end = false;
            int index = 0;
            int current_round = 0;
            GenericSounds.PlayGetReadySound(0);
            await Task.Delay(2000);


            while (index != workout.combos.Count)
            {
                ChangeTextOnLabel(round_label, (current_round + 1 + "/" + 3));

                ComboClass currentCombo = workout.combos[index];
                //predelat


                if(index+1 != workout.combos.Count)
                {
                    ChangeTextOnLabel(nextR_label, "Next round: " + workout.combos[index + 1].strikes[0].name);

                }
                else
                {
                    ChangeTextOnLabel(nextR_label, "Last round: ");

                }
                ChangeTextOnLabel(count_label, (index+1+ "/"+ workout.combos.Count()).ToString());


                combo_label.Text = currentCombo.strikes[0].name;
                // 1. Pøehrání zvuku kombinace
                await PlaySoundAsync(currentCombo);


                await Task.Delay(1000);
                combo_label.BackgroundColor = Color.FromRgb(255, 0, 0);

                // 2. Pøehrání zvuku "GO"
                await GenericSounds.PlayGoSound(0);

                // 3. Odpoèítávání 15 sekund pro kolo
                await StartTimerAsync(currentCombo.exercise_time+1) ;


                // 4. Pøehrání zvuku pauzy

                if (index + 1 != workout.combos.Count)
                {
                    //predelat
                    await GenericSounds.PlayBreakSound(0);
               
                    ChangeTextOnLabel(combo_label, "Break");
                    combo_label.BackgroundColor = Color.FromRgb(0, 255, 0)
                        
                        ;
                    // 5. Pauza na 10 sekund
                    await Task.Delay(1000);
                    await GenericSounds.PlayNextExercise(0);
                    await Task.Delay(1500);
                    await workout.combos[index + 1].PlaySound();
                    await StartTimerAsync(workout.break_time + 1);
    
                }
   

                if (index + 1 == workout.combos.Count)
                {
                    await GenericSounds.PlayBreakSound(0);
                    ChangeTextOnLabel(combo_label, "Next round");
                    // 4. Pøehrání zvuku pauzy

                    combo_label.BackgroundColor = Color.FromRgb(0, 255, 0);
                    // 5. Pauza na 10 sekund
                    await StartTimerAsync(workout.break_time*5 + 1);

                    index = -1;
                    current_round++;
                }
                index++;

            }
        }

        public async Task PlaySoundAsync(ComboClass combo)
        {
            await Task.Run(() => combo.PlaySound());
        }

        private async Task StartTimerAsync(int seconds)
        {
            for (int i = 1; i <= seconds; i++)
            {
                if (end) return; // Pokud je ukonèeno, ukonèi funkci
                if(stopped) time_label.BackgroundColor = Color.FromRgb(128, 128, 128);
                

                while (stopped)
                {
                    await Task.Delay(1000); // Poèká 1 sekundu

                };
                 time_label.BackgroundColor = Color.FromRgb(100, 0, 255);


                if (skipped) {
                    skipped= false;
                    break;

                };
                await Task.Delay(1000); // Poèká 1 sekundu

                // Aktualizace UI prvku na hlavním vláknì
                MainThread.BeginInvokeOnMainThread(() =>
                {
                    time_label.Text = (seconds-i).ToString();
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

        private void EndFunc(object sender, EventArgs e)
        {
            EndFunc();
        }

        private void EndFunc()
        {
            end = true;
            App.Current.MainPage = new NavigationPage(new BegiPage2());
        }

        private void ChangeTextOnLabel(Label nazev_labelu, string text)
        {
            nazev_labelu.Text = text;
        }
    }
}
