using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinPlayer.Playlist
{
    static class PlayListXMLMap
    {
        public static string Path = @"..\..\PlayList\PlayList.xml";

        public static class Root
        {
            public static string ElementName = "Playlists";

            public static class PlayList
            {
                public static string ElementName = "Playlist";
                public static class Attributes
                {
                    public static string Name = "Name";
                }
                public static class MediaRecord
                {
                    public static string ElementName = "MediaRecord";
                    public static class Attributes
                    {
                        public static string Path = "Path";
                    }
                }
            }
        }
    }
}
