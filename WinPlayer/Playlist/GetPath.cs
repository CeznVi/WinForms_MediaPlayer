using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinPlayer.Playlist
{
    static class GetPath
    {
        public static string MediaDir()
        {
            string path = Directory.GetCurrentDirectory();
            path = Directory.GetParent(Directory.GetParent(Directory.GetParent(path).FullName).FullName).FullName + "\\Media";
            return path;
        }
    }
}
