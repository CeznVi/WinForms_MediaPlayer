using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinPlayer.Playlist
{
    static class MediaFilter
    {
        /// <summary>
        /// Статический масив имен аудиофайлов
        /// </summary>
        static readonly string[] nameAudioFile =
        {
            "wav", "acc", "wma", "wmv", "mp3", "mpa", "mpe", "m4a", "mid", "midi"
        };
        /// <summary>
        /// Статический масив имен видеофайлов
        /// </summary>
        static readonly string[] nameVideoFile =
        {
            "avi", "mpg", "mpeg", "m1v", "mp4", "mov", "3gp", "3gp2","3gpp", "mkv"
        };
        /// <summary>
        /// Статический масив имен медииофайлов (аудио+видео)
        /// </summary>
        static readonly string[] nameAllMediaFile =
        {
            "wav", "acc", "wma", "wmv", "mp3", "mpa", "mpe", "m4a", "mid", "midi",
            "avi", "mpg", "mpeg", "m1v", "mp4", "mov", "3gp", "3gp2","3gpp", "mkv"
        };

        public static bool IsMediaFile(string path)
        {
           return true;
        }

        public static string GetOpenFileDialogFilter()
        {
            return
                "Video|*." + String.Join("*.", nameVideoFile.Select(x => x + ";").ToArray()) +
                "|Audio|*." + String.Join("*.", nameAudioFile.Select(x => x + ";").ToArray()) +
                "|AllMedia|*." + String.Join("*.", nameAllMediaFile.Select(x => x + ";").ToArray());
        }
    }
}
