using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsMediaPlayer.PlayList
{
    public class MediaRecord
    {
        private string _path;

        public MediaRecord(string pathToMedia)
        {
            Path = pathToMedia;
        }

        /// прикрутить проверку майн тайп (медиа тайп)
        public string Path
        {
            get { return _path; }

            set 
            { 
                if(!File.Exists(value))
                {
                    throw new FileNotFoundException($"Файл по указаному пути {value} не существует");
                }

                if(true)
                {
                    _path = value;

                }
                else
                {
                    throw new ArgumentException("Некоректный формат файла");

                }

            }



        }

        public override string ToString()
        {
            return _path.Split('\\').Last(); // name and rashirenie file
        }

    }
}
