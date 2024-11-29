using System.Diagnostics;
using Microsoft.Maui.Storage;
using Plugin.Maui.Audio;
using System;
using System.Threading;
using System.Threading.Tasks;

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

        // Pomocná metoda pro přehrávání zvuku s tokenem pro zrušení
        private static async Task PlaySoundAsync(string soundPath, CancellationToken token)
        {
            var audioPlayer = AudioManager.Current.CreatePlayer(await FileSystem.OpenAppPackageFileAsync(soundPath));
            audioPlayer.Play();

        }

        public static async Task PlayPunchSound2( CancellationToken token)
        {
            var audioPlayer = AudioManager.Current.CreatePlayer(await FileSystem.OpenAppPackageFileAsync(punch_sound));
            audioPlayer.Play();

        }


        public static Task PlayPunchSound(CancellationToken token) => PlaySoundAsync(punch_sound, token);
        public static Task PlayGetReadySound(CancellationToken token) => PlaySoundAsync(get_ready_sound, token);
        public static Task PlayMoveSound(CancellationToken token) => PlaySoundAsync(move_sound, token);
        public static Task PlayDefenceSound(CancellationToken token) => PlaySoundAsync(defence_sound, token);
        public static Task PlayGoSound(CancellationToken token) => PlaySoundAsync(go_sound, token);
        public static Task PlayBreakSound(CancellationToken token) => PlaySoundAsync(break_sound, token);
        public static Task PlayNextExercise(CancellationToken token) => PlaySoundAsync(next_exercise_sound, token);
    }
}
