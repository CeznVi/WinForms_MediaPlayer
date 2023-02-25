using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsMediaPlayer.PlayList
{
    static class PlayListXmlMap
    {
        //ADRES NOT CORECT NEED FIX
        public static string Path = @"C:\Users\Admin\Desktop\Програмирование\source\repos\ItStep_HW_OOP\WindowsMedia Player\WindowsMediaPlayer\WindowsMediaPlayer\PlayList\PlayList.xml";
        
        public static class Root
        {
            public static string ElementName = "Playlists";

            public static class PlayList
            {
                public static string ElementName = "Playlist";

                public static class Attribute
                {
                    public static string Name = "Name";
                }
                public static class MediaRecord
                {
                    public static string ElementName = "MediaRecord";


                    public static class Attribute
                    {
                        public static string Path = "Path";
                    }

                }


            }
        }
    }
}
