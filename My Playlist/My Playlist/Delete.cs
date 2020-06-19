using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace My_Playlist
{
    //this class for deleting from (allsongs , playlists)
    public class Delete
    {
        public string filepathes= @"C:\Users\Mido\Desktop\Musically\My Playlist\My Playlist\bin\Debug\";
        //remove from allsongs
        public void delete_all(string song_name)
        {
            
            if (File.Exists("AllSongs.xml"))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("AllSongs.xml");
                XmlNodeList list = doc.GetElementsByTagName("Song");
                int c = list.Count;
                for (int i = 0; i < list.Count; i++)
                {
                    XmlNodeList childs = list[i].ChildNodes;
                    if (childs[0].InnerText == song_name)
                    {
                        list[i].ParentNode.RemoveChild(list[i]);
                        File.Delete(@childs[3].InnerText);
                        doc.Save("AllSongs.xml");
                        break;
                    }
                }
                //delete the file if there aren't any songs
                if (c == 1)
                    File.Delete("AllSongs.xml");
            }
            if (File.Exists("PlaylistsSongs.xml"))
            {
                //delete song from all playlists
                XmlDocument doc2 = new XmlDocument();
                doc2.Load("PlaylistsSongs.xml");
                XmlNodeList list2 = doc2.GetElementsByTagName("playlistSong");
                int c2 = list2.Count;
                for (int i = 0; i < list2.Count; i++)
                {
                    XmlNodeList childs = list2[i].ChildNodes;
                    if (childs[0].InnerText == song_name)
                    {
                        //deleteSong = childs[3].InnerText;
                        list2[i].ParentNode.RemoveChild(list2[i]);
                        doc2.Save("PlaylistsSongs.xml");
                        break;
                    }
                }
                //delete the file if there aren't any songs
                if (c2 == 1)
                    File.Delete(@filepathes+"PlaylistsSongs.xml");
            }
     
        }
        //delete playlist
        public void delete_playlist(string playlistname)
        {
            if (File.Exists("Playlists.xml"))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Playlists.xml");
                XmlNodeList list = doc.GetElementsByTagName("playlist");
                int c = list.Count;
                for (int i = 0; i < list.Count; i++)
                {
                    XmlNodeList childs = list[i].ChildNodes;
                    if (childs[0].InnerText == playlistname)
                    {
                        list[i].ParentNode.RemoveChild(list[i]);
                        doc.Save("Playlists.xml");
                        break;
                    }
                }
                //delete the file if there aren't any songs
                if (c == 1)
                    File.Delete(@filepathes+"Playlists.xml");
            }
            //delete the song from playlistSongs file
            if (File.Exists("PlaylistsSongs.xml"))
            {
                XmlDocument doc2 = new XmlDocument();
                doc2.Load("PlaylistsSongs.xml");
                XmlNodeList list2 = doc2.GetElementsByTagName("playlistSong");
                int c = list2.Count;
                for (int i = 0; i < list2.Count; i++)
                {
                    XmlNodeList childs = list2[i].ChildNodes;
                    if (childs[4].InnerText == playlistname)
                    {
                        list2[i].ParentNode.RemoveChild(list2[i]);
                        doc2.Save("PlaylistsSongs.xml");
                        break;
                    }
                }
                //delete the file if there aren't any songs
                if (c == 1)
                    File.Delete(@filepathes+"PlaylistsSongs.xml");

            }
        }

        //remove song from playlist
        public void delete_Song_From_playlist(string song_name, string playlistname)
        {
            if (File.Exists("PlaylistsSongs.xml"))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("PlaylistsSongs.xml");
                XmlNodeList list = doc.GetElementsByTagName("playlistSong");
                int c = list.Count;
                for (int i = 0; i < list.Count; i++)
                {
                    XmlNodeList childs = list[i].ChildNodes;
                    if (childs[0].InnerText == song_name && childs[4].InnerText == playlistname)
                    {
                        list[i].ParentNode.RemoveChild(list[i]);
                        doc.Save("PlaylistsSongs.xml");
                        break;
                    }
                }
                //delete the file if there aren't any songs
                if (c == 1)
                    File.Delete(@filepathes+"PlaylistsSongs.xml");
            }
        }

    }
}
