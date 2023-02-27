using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinPlayer.Playlist
{
    class MediaFilter
    {
        private string[] nameMediFile =
        {
            "wav", "acc", "wma", "wmv", "avi", "mpg", "mpeg", "m1v", "mp2", "mp3", "mpa", "mpe", "m3u", "mp4", "mov",
            "3gp", "3gp2","3gpp","m4a","cda","aif", "aifc", "aiff", "mid", "midi","rmi", "mkv",
            "WAV", "AAC", "WMA", "WMV", "AVI", "MPG", "MPEG", "M1V", "MP2", "MP3", "MPA", "MPE",
            "M3U","MP4","MOV","3G2","3GP2", "3GP",

                //;*.3GPP;*.M4A;*.CDA;*.AIF;*.AIFC;*.AIFF;*.MID;*.MIDI;*.RMI;*.MKV"

        };

        public static bool isMediaFile(string path)
        {
            
            return true;
        }

        public static string GetOpenFileDialogFilter()
        {
            throw new NotImplementedException();
        }
    }
}
