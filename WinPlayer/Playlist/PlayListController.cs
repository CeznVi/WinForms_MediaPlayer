using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WinPlayer.Playlist
{
    public class PlayListController
    {
        private string _pathToXMLFile;
        public List<PlayList> PlayLists;

        public string PathToXml {
            get { return _pathToXMLFile; } 
            set {
                if (!File.Exists(value))
                {
                    throw new FileNotFoundException();
                }
                if(Path.GetExtension(value).ToLower() != ".xml")
                {
                    throw new ArgumentException("Не корректны йформат файла");
                }
                _pathToXMLFile = value;
            }
        }

        public PlayListController(string pathToXml)
        {
            PlayLists = new List<PlayList>();
            PathToXml = pathToXml;
            LoadXmlData();
        }

        private void LoadXmlData()
        {
            XDocument xDocument = XDocument.Load(PathToXml);

            //получаю доступ к корневому элементу
            XElement rootElement = xDocument.Element(PlayListXMLMap.Root.ElementName);

            IEnumerable<XElement> playlistElements = rootElement.Elements(PlayListXMLMap.Root.PlayList.ElementName);

            foreach (var onePlayList in playlistElements)
            {
                PlayList tmp = new PlayList();
                tmp.MediaRecords = new List<MediaRecord>();
                tmp.Name = onePlayList.Attribute(PlayListXMLMap.Root.PlayList.Attributes.Name).Value;

                IEnumerable<XElement> mediaRecords = onePlayList.Elements(PlayListXMLMap.Root.PlayList.MediaRecord.ElementName);
                foreach (var oneRecord in mediaRecords)
                {
                    tmp.MediaRecords.Add(new MediaRecord(oneRecord.Attribute(PlayListXMLMap.Root.PlayList.MediaRecord.Attributes.Path).Value));
                }
                PlayLists.Add(tmp);
            }
        }

        public void AddNewPlayList(PlayList playlist)
        {
            throw new NotImplementedException();
        }
        public void RemovePlayList(string playListName)
        {
            throw new NotImplementedException();
        }
        public void RenamePlayList(string oldName, string newName)
        {
            throw new NotImplementedException();
        }
        public void AddNewMediaRecord(MediaRecord mediaRecord, PlayList playlist)
        {
            throw new NotImplementedException();
        }
        public void RemoveMediaRecord(MediaRecord mediaRecord, PlayList playlist)
        {
            throw new NotImplementedException();
        }
    }
}
