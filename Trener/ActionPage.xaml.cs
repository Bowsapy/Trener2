using System.Diagnostics;
using Microsoft.Maui.Storage;
using Plugin.Maui.Audio;
using System;
using System.Threading.Tasks;
using Microsoft.Maui.Dispatching;

namespace Trener
{
    public partial class ActionPage : ContentPage
    {
        WorkoutClass workout;
        bool stopped;
        bool skipped;
        Stopwatch timer = new Stopwatch();
        bool wait;
        bool end;

        public ActionPage(WorkoutClass workout)
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
            int currentCom_index = 0;
            int remaining_rounds = 1;
            int adj_ktime;
            double divisor = 1;
            int current_round = 1;
            wait = true;
            end = false;
            int current_rep =0;
            remaining_rounds = workout.num_of_rounds;
            int function;
            bool is_advice=false;

            Task threadC = Task.Run(() => ZobrazCas());

            skipped = false;
            List<IStrike> current_strikes;
            int index_in_combo;
            await Task.Delay(2000);
            GenericSounds.PlayGetReadySound(0);
            await Task.Delay(2000);


            while (end != true)
            {
              

                    ChangeTextOnLabel(round_label, (current_round).ToString() + "/" + (workout.num_of_rounds).ToString());

                ChangeTextOnLabel(count_label, ((currentCom_index+1).ToString()+ "/" +(workout.combos.Count)).ToString());



                /* Ovìø, že není stopka nebo skip */
                ComboClass kom = workout.combos[currentCom_index];
                current_strikes = kom.GetStrikes();

                if (current_strikes[0].GetType() == typeof(AdviceClass))
                {
                    is_advice = true;
                }
                else
                {
                    is_advice=false;
                }

                // Zobraz text kombinace
                combo_label.Text = kom.GetName();

                int combo_length = kom.GetName().Length;
                //                int function = (-4 * combo_length + 10);


                if(combo_length > 8)
                {
                    function = 50;

                }
                else if (combo_length> 4)
                {
                    function = 80;

                }
                else
                {
                    function = 100;

                }


                combo_label.FontSize = function;
                // Pøehraj atributy kombinace
                if (is_advice)
                {
                    strike_label.BackgroundColor = Color.FromRgb(0, 255, 0);

                }
                else
                {
                    strike_label.BackgroundColor = Color.FromHex("#9D00FF");

                }

                await PlaySoundAsync(kom);

                await Task.Delay(500);
                index_in_combo = 0;
                adj_ktime = Convert.ToInt32(Math.Round(kom.time/divisor));

    
                //uprav tuhle podminku
                if ( true )
                {


                    for (int i = 0; i < kom.reps; i++)
                    {

                        current_rep++;
                        if (!is_advice)
                        {
                            strike_label.BackgroundColor = Color.FromHex("#9D00FF");

                        }


                        //prepis tyhle podminky 
                        if (!skipped && !is_advice)

                        {
                            strike_label.BackgroundColor = Color.FromRgb(255, 0, 0);

                            GenericSounds.PlayGoSound(0);
                        }
                        if (!skipped)
                        {
                            await Task.Delay(600);
                        }

                   


                        ChangeTextOnLabel(rep_label, ((current_rep).ToString() + "/" + (kom.reps).ToString()));


                        for (int q = 0; q < kom.strikes.Count; q++)
                        {

                            if (end) return;

                            if (skipped) break;

                            await StopAll();


                            if (!skipped)
                            {

                                if (!is_advice)
                                {
                                    strike_label.Text = current_strikes[index_in_combo].name;

                                }

                                if (current_strikes[index_in_combo].GetType() == typeof(PunchClass))
                                {
                                    await GenericSounds.PlayPunchSound(100);
                                }
                                else if (current_strikes[index_in_combo].GetType() == typeof(DefenceClass))

                                {
                                    await Task.Delay(50);

                                    await GenericSounds.PlayDefenceSound(0);

                                }
                                else if (current_strikes[index_in_combo].GetType() == typeof(AdviceClass))

                                {
                                    await Task.Delay(0);


                                }
                                else if (current_strikes[index_in_combo].GetType() == typeof(MoveClass))
                                {
                                    await Task.Delay(200);

                                    GenericSounds.PlayMoveSound(0);
                                }
                                index_in_combo++;

                                if (!is_advice)
                                {
                                    await Task.Delay(Convert.ToInt32(600 / divisor));

                                }


                            }

                        }
                        if (!is_advice)
                        {
                            strike_label.BackgroundColor = Color.FromHex("#9D00FF");

                        }


                        index_in_combo = 0;
                        strike_label.Text = "";

                        if (!skipped & !is_advice)
                        {
                            await Task.Delay(1200);
                        }
                    }
                }
           
                current_rep = 0;

                // Cas potrebny ke kombinaci
                if(!is_advice)
                {
                    await Task.Delay(1500);

                }
                currentCom_index++;
                ChangeTextOnLabel(rep_label, ("1" + "/" + (kom.reps).ToString()));



                if ((currentCom_index) == workout.TotalNumOfCombos())
                {
                    currentCom_index = 0;
                    remaining_rounds--;
                    current_round++;
                    divisor = divisor * 1.5; /*zrychli èas*/

                }

                if (remaining_rounds == 0)
                {
                    EndFunc();
                }

                skipped = false;
            }
        }

    
        public async Task PlaySoundAsync(ComboClass combo)
        {
            // Pøímý await bez použití Task.Run
            await combo.PlaySound(); // Pokud PlaySound mùže být upraven na asynchronní
            wait = false;
        }





        private void StopFunc(object sender, EventArgs e)
        {
            stopped = !stopped;
        }

        private void SkipniFunc(object sender, EventArgs e)
        {
            skipped = true;
        }

        private async Task StopAll()
        {
            while (stopped)
            {
                await Task.Delay(1000);
            }
        }
        private void EndFunc(object sender, EventArgs e) { 

            end = !end;
            App.Current.MainPage = new NavigationPage(new BegiPage2());

        }
        private void EndFunc()
        {

            end = !end;
            App.Current.MainPage = new NavigationPage(new BegiPage2());

        }
        private void ChangeTextOnLabel(Label nazev_labelu, string text)
        {
            nazev_labelu.Text = text;
        }

        private async Task ZobrazCas()
        {

            while (true)
            {

                await Task.Delay(1000); // Aktualizace každou sekundu
                TimeSpan ts = timer.Elapsed;

                if (!stopped)

                {
                    timer.Start();

                    string elapsedTime = String.Format("{0:00}:{1:00}",ts.Minutes, ts.Seconds);

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
        }
    }
}
