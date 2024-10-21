using System.Diagnostics;
using Microsoft.Maui.Storage;
using Plugin.Maui.Audio;
using System;
using System.Threading.Tasks;
using Microsoft.Maui.Dispatching;
namespace Trener
{
    public static class GenericSounds
    {
        public static string punch_sound = @"Sounds\other\ping-sound.mp3";
        public static string move_sound = @"Sounds\other\step-sound.mp3";
        public static string defence_sound = @"Sounds\other\miss-sound.mp3";
        public static string go_sound = @"Sounds\other\go-sound.mp3";
        public static string break_sound = @"Sounds\other\break-sound.mp3";
        public static string get_ready_sound = @"Sounds\other\get-ready-sound.mp3";

        public static string next_exercise_sound = @"Sounds\other\nextexercise-sound.mp3";




        public static async Task PlayPunchSound(int time)
        {

            
                var audioPlayer = AudioManager.Current.CreatePlayer(await FileSystem.OpenAppPackageFileAsync(punch_sound));


                audioPlayer.Play();


            await Task.Delay((int)audioPlayer.Duration);


        }
        public static async Task PlayGetReadySound(int time)
        {


            var audioPlayer = AudioManager.Current.CreatePlayer(await FileSystem.OpenAppPackageFileAsync(get_ready_sound));


            audioPlayer.Play();


            await Task.Delay((int)audioPlayer.Duration);


        }

        public static async Task PlayMoveSound(int time )
        {


            var audioPlayer = AudioManager.Current.CreatePlayer(await FileSystem.OpenAppPackageFileAsync(move_sound));


            audioPlayer.Play();


            await Task.Delay((int)audioPlayer.Duration);


        }

        public static async Task PlayDefenceSound(int time)
        {


            var audioPlayer = AudioManager.Current.CreatePlayer(await FileSystem.OpenAppPackageFileAsync(defence_sound));


            audioPlayer.Play();


            await Task.Delay((int)audioPlayer.Duration);


        }
        public static async Task PlayGoSound(int time)
        {


            var audioPlayer = AudioManager.Current.CreatePlayer(await FileSystem.OpenAppPackageFileAsync(go_sound));


            audioPlayer.Play();


            await Task.Delay((int)audioPlayer.Duration);


        }

        public static async Task PlayBreakSound(int time)
        {


            var audioPlayer = AudioManager.Current.CreatePlayer(await FileSystem.OpenAppPackageFileAsync(break_sound));


            audioPlayer.Play();


            await Task.Delay((int)audioPlayer.Duration);


        }
        public static async Task PlayNextExercise(int time)
        {


            var audioPlayer = AudioManager.Current.CreatePlayer(await FileSystem.OpenAppPackageFileAsync(next_exercise_sound));


            audioPlayer.Play();


            await Task.Delay((int)audioPlayer.Duration);


        }


    }
}
