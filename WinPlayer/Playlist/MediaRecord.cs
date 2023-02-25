using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinPlayer.Playlist
{
    public class MediaRecord
    {
        private string _path;
        public MediaRecord(string pathToMedia)
        {
            Path = pathToMedia;
        }
        public string Path
        {
            get { return _path; }
            set
            {
                //файл существует
                if (!File.Exists(value))
                {
                    throw new FileNotFoundException($"Файл по указанному пути {value} Не существует");
                }
                if (true) //файл допустимого росширения
                {
                    _path = value;
                } else
                {
                    throw new ArgumentException("Не корректны йформат файла");
                }
            }
        }
        public override string ToString()
        {
            return _path.Split('\\').Last();        //получаем имя и росширение файла....
        }
    }
}
