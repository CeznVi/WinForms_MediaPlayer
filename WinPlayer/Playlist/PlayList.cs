using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinPlayer.Playlist
{
    public class PlayList
    {
        public string Name { get; set; }

        public List<MediaRecord> MediaRecords { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
