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
        public static string lang = Localization.GetCurrentLanguage();

        public static string punch_sound = $@"Sounds\en\other\ping-sound.mp3";
        public static string move_sound = $@"Sounds\en\other\step-sound.mp3";
        public static string defence_sound = $@"Sounds\en\other\miss-sound.mp3";
        public static string go_sound = $@"Sounds\{lang}\other\go-sound.mp3";
        public static string break_sound = $@"Sounds\{lang}\other\break-sound.mp3";
        public static string get_ready_sound = $@"Sounds\{lang}\other\get-ready-sound.mp3";

        // Pomocná metoda pro přehrávání zvuku s tokenem pro zrušení
        private static async Task PlaySoundAsync(string soundPath, CancellationToken token)
        {
            var tcs = new TaskCompletionSource<bool>();

            // Vytvoření přehrávače na jiném vlákně
            var audioPlayer = await Task.Run(async () =>
            {
                var player = AudioManager.Current.CreatePlayer(await FileSystem.OpenAppPackageFileAsync(soundPath));
                player.PlaybackEnded += (s, e) => tcs.TrySetResult(true);
                return player;
            });

            audioPlayer.Play();

            using (token.Register(() => {
                audioPlayer.Stop();
                tcs.TrySetResult(true);
            }))
            {
                await Task.WhenAny(tcs.Task, Task.Delay(Timeout.Infinite, token));
            }
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
    }
}
