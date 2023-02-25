using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WindowsMediaPlayer.PlayList
{
    public class PlayListController
    {
        private string _pathXMLFile;
        public List<PlayList> PlayLists;

        public string PathToXML
        {
            get { return _pathXMLFile; }

            set
            {
                if(!File.Exists(value)) 
                {
                    throw new FileNotFoundException();
                }
                if(Path.GetExtension(value).ToLower() != ".xml")
                {
                    throw new ArgumentException("Некоректный формат файла");

                }
                _pathXMLFile = value;
            }
        
        }


        public PlayListController(string pathToXML)
        {
            PlayLists = new List<PlayList>();
            PathToXML = pathToXML;
            loadXMLData();
        }

        private void loadXMLData()
        {
            XDocument xDocument = XDocument.Load(PathToXML);
            //dostup k kornevomy el
            XElement rootElement = xDocument.Element(PlayListXmlMap.Root.ElementName);

            IEnumerable<XElement> playListElements = rootElement.Elements(PlayListXmlMap.Root.PlayList.ElementName);

            foreach(var onePlayList in playListElements)
            {
                PlayList tmp = new PlayList();
                tmp.MediaRecords = new List<MediaRecord>();
                tmp.Name = onePlayList.Attribute(PlayListXmlMap.Root.PlayList.Attribute.Name).Value;

                IEnumerable<XElement> mediaRecords = onePlayList.Elements(PlayListXmlMap.Root.PlayList.MediaRecord.ElementName);

                foreach(var oneRecord in mediaRecords)
                {
                    tmp.MediaRecords.Add(new MediaRecord(oneRecord.Attribute(PlayListXmlMap.Root.PlayList.MediaRecord.Attribute.Path).Value));
                }

                PlayLists.Add(tmp);
            }
        }

        public void AddNewPlaylist(PlayList playList)
        {

        }

        public void RemovePlaylist(string playListName)
        {

        }

        public void RenamePlaylist(string oldName, string newName)
        {

        }

        public void AddNewMediaRecord(MediaRecord mediaRecord, PlayList playList)
        {

        }

        public void RemoveMediaRecord(MediaRecord mediaRecord, PlayList playList)
        {

        }

    }
}
