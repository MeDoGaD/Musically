﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace My_Playlist
{
    public partial class b : Form
    {
        public b()
        {
            InitializeComponent();
        }

        private void Addplaybtn_Click(object sender, EventArgs e)
        {
            bool check = false;
            if(File.Exists("Playlists.xml"))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Playlists.xml");
                XmlNodeList list = doc.GetElementsByTagName("playlist");
               
                for (int i = 0; i < list.Count; i++)
                {
                    XmlNodeList child = list[i].ChildNodes;
                    if (child[0].InnerText == playnametxt.Text)
                        check = true;

                }
            }
            if (check == false)
            {
                if (!File.Exists("Playlists.xml"))
                {
                    XmlWriter writer = XmlWriter.Create("Playlists.xml");
                    writer.WriteStartDocument();
                    writer.WriteStartElement("PlayLists");
                    writer.WriteStartElement("playlist");
                    writer.WriteStartElement("Name");
                    writer.WriteString(playnametxt.Text);
                    writer.WriteEndElement();

                    writer.WriteEndElement();
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                    writer.Close();
                }
                else
                {
                    XmlDocument doc2 = new XmlDocument();
                    XmlElement son = doc2.CreateElement("playlist");
                    XmlElement node = doc2.CreateElement("Name");
                    node.InnerText = playnametxt.Text;
                    son.AppendChild(node);

                    doc2.Load("Playlists.xml");
                    XmlElement root = doc2.DocumentElement;
                    root.AppendChild(son);
                    doc2.Save("Playlists.xml");
                }

                Form1.LoadPlaylistsMenu();
                this.Close();
            }
            else
                MessageBox.Show("There is a playlist with the same name", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
