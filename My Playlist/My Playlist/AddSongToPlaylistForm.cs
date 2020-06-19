using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace My_Playlist
{
    public partial class AddSongToPlaylistForm : Form
    {
        public AddSongToPlaylistForm()
        {
            InitializeComponent();
        }

        public string itemname, titleval, artistval, albumval, pathval;
        public string[] paths;


        private void AddSongToPlaylistForm_Load(object sender, EventArgs e)
        {
            playcombo.Items.Clear();
            if (File.Exists("Playlists.xml"))
            {

                XmlDocument doc = new XmlDocument();
                doc.Load("Playlists.xml");
                XmlNodeList list = doc.GetElementsByTagName("playlist");

                for (int i = 0; i < list.Count; i++)
                {
                    XmlNodeList child = list[i].ChildNodes;
                    string playname = child[0].InnerText;
                    playcombo.Items.Add(playname);
                }
            }
        }

        
        bool check = false;
        public void addSongToPlayList()
        {
            if (!File.Exists("PlaylistsSongs.xml"))
            {
                XmlWriter writer = XmlWriter.Create("PlaylistsSongs.xml");
                writer.WriteStartDocument();
                writer.WriteStartElement("AllPlayListsSongs");
                writer.WriteStartElement("playlistSong");
                writer.WriteStartElement("Name");
                writer.WriteString(s.name);
                writer.WriteEndElement();
                writer.WriteStartElement("Artist");
                writer.WriteString(s.Artist);
                writer.WriteEndElement();
                writer.WriteStartElement("Album");
                writer.WriteString(s.Album);
                writer.WriteEndElement();
                writer.WriteStartElement("Path");
                writer.WriteString(s.path);
                writer.WriteEndElement();
                writer.WriteStartElement("PLayList_Name");
                writer.WriteString(playcombo.SelectedItem.ToString());
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();


            }
            else
            {
                XmlDocument doc2 = new XmlDocument();
                XmlElement son = doc2.CreateElement("playlistSong");

                XmlElement node = doc2.CreateElement("Name");
                node.InnerText = s.name;
                son.AppendChild(node);
                node = doc2.CreateElement("Artist");
                node.InnerText = s.Artist;
                son.AppendChild(node);
                node = doc2.CreateElement("Album");
                node.InnerText = s.Album;
                son.AppendChild(node);
                node = doc2.CreateElement("Path");
                node.InnerText = s.path;
                son.AppendChild(node);
                node = doc2.CreateElement("PLayList_Name");
                node.InnerText = playcombo.SelectedItem.ToString();
                son.AppendChild(node);


                doc2.Load("PlaylistsSongs.xml");
                XmlElement root = doc2.DocumentElement;
                root.AppendChild(son);
                doc2.Save("PlaylistsSongs.xml");
            }
        }

        Song s = new Song();
        private void Addplaybtn_Click(object sender, EventArgs e)
        {
            
                check = false;

                if (File.Exists("AllSongs.xml"))
                {

                    XmlDocument doc = new XmlDocument();
                    doc.Load("AllSongs.xml");
                    XmlNodeList list = doc.GetElementsByTagName("Song");


                    for (int j = 0; j < list.Count; j++)
                    {
                        XmlNodeList child = list[j].ChildNodes;
                        if (child[0].InnerText == User_controllers.Songaya.NAME)
                        {
                           s.name = child[0].InnerText;
                            s.Artist = child[1].InnerText;
                            s.Album = child[2].InnerText;
                            s.path = child[3].InnerText;
                            check = true;
                            break;

                        }
                    }

                }

                if (check == true)
                {
                    addSongToPlayList();
                }

            this.Close();
        }
    }
}
