using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsMediaPlayer.PlayList
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
