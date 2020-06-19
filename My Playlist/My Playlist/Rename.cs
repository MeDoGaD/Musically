using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace My_Playlist
{
  public class Rename
    {
        /*
         * note: most of the variables are paths
         * if the file in the project directory (.\project\bin\Debug) complete paths are not necessary
         */
   
        public void rename_xml_name(string old_name, string new_name)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("AllSongs.xml");
            XmlNodeList list = doc.GetElementsByTagName("Song");
            for (int i = 0; i < list.Count; i++)
            {
                XmlNodeList childs = list[i].ChildNodes;
                if (childs[0].InnerText == old_name)
                {
                    childs[0].InnerText = new_name;
                    doc.Save("AllSongs.xml");
                    break;
                }
            }
            if (File.Exists("PlaylistsSongs.xml"))
            {
                doc = new XmlDocument();
                doc.Load("PlaylistsSongs.xml");
                list = doc.GetElementsByTagName("playlistSong");
                for (int i = 0; i < list.Count; i++)
                {
                    XmlNodeList childs = list[i].ChildNodes;
                    if (childs[0].InnerText == old_name)
                    {
                        childs[0].InnerText = new_name;
                        doc.Save("PlaylistsSongs.xml");
                        break;
                    }
                }
            }

        }

    }
}