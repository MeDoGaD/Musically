using My_Playlist.User_controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Media;
using System.IO;
using My_Playlist;
using System.Xml.Serialization;

namespace My_Playlist
{
    public partial class Form1 : Form
    {
        public bool IsClicked;

        public string[] names, paths;
        public static string sname, path;

        public static string songname;
        public string searchname;
        public List<Song> songs_list = new List<Song>();
        public Form1()
        {
            InitializeComponent();
            Speaker_bt.Hide();
            IsClicked = false;
            axWindowsMediaPlayer1.settings.volume = 100;
            DeletePlaylist_bt.Hide();
        }


        

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAllSongsMenu();
            LoadPlaylistsMenu();
        }


        public void LoadAllSongsMenu()
        {

            SongsLabel.Text = "ALL SONGS";
            DeletePlaylist_bt.Hide();
            BackToAllSongs_bt.Hide();
            if (File.Exists("AllSongs.xml"))
            {
                SongsPanel.Controls.Clear();
                FileStream fs = new FileStream("AllSongs.xml", FileMode.Open);
                XmlSerializer xs = new XmlSerializer(songs_list.GetType());
                songs_list = (List<Song>)xs.Deserialize(fs);
                fs.Close();
                names = new string[songs_list.Count];
                paths = new string[songs_list.Count];
                for(int i=0;i<songs_list.Count;i++)
                {
                    string titleval = songs_list[i].name;
                    string pathval = songs_list[i].path;
                    sname = titleval;
                    path = pathval;
                    paths[i] = pathval;
                    names[i] = titleval;
                   User_controllers.Songaya s = new User_controllers.Songaya();
                    s.songnamelbl.Text = sname;
                    SongsPanel.Controls.Add(s);
                }
            }
        }

        public static void LoadPlaylistsMenu()
        {
            playcombo.Text = "Playlists";
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
        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void Panel4_Click(object sender, EventArgs e)
        {
            All_Songs s = new All_Songs();
            s.Show();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            All_Songs s = new All_Songs();
            
            s.Show();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            All_Songs s = new All_Songs();
            s.Show();
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel3_Click(object sender, EventArgs e)
        {
            playlists s = new playlists();
            s.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //dah by3ml search f all songs bs
            XmlDocument doc = new XmlDocument();
            doc.Load("AllSongs.xml");
            XmlNodeList list = doc.GetElementsByTagName("Song");
            bool exist = false;
            for (int i = 0; i < list.Count; i++)
            {
                XmlNodeList childs = list[i].ChildNodes;
                if (childs[0].InnerText == search_txt.Text)
                {
                    All_Songs allSongs = new All_Songs();
                    allSongs.searchname = search_txt.Text;
                    allSongs.Show();
                    exist = true;
                    break;
                }
            }
            if (!exist)
                MessageBox.Show("This Song is not found !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            search_txt.Clear();
        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Search_txt_Click(object sender, EventArgs e)
        {
            search_txt.Text = "";
            search_txt.TextAlign = HorizontalAlignment.Left;
        }

        private void Label1_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void imageButtonCustom1_Click(object sender, EventArgs e)
        {
            
            //dah by3ml search f all songs
            XmlDocument doc = new XmlDocument();
            doc.Load("AllSongs.xml");
            XmlNodeList list = doc.GetElementsByTagName("Song");
            bool exist = false;
            for (int i = 0; i < list.Count; i++)
            {
                XmlNodeList childs = list[i].ChildNodes;
                if (childs[0].InnerText == search_txt.Text)
                {
                    SongsPanel.Controls.Clear();
                    Songaya s = new Songaya();
                    s.songnamelbl.Text = search_txt.Text;
                    SongsPanel.Controls.Add(s);
                    SongsLabel.Text = "Search for: " + search_txt.Text;
                    BackToAllSongs_bt.Show();

                    exist = true;
                    break;
                }
            }
            if (!exist)
                MessageBox.Show("This Song is not found !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            search_txt.Clear();
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void Exit_bt_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void Max_bt_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;

        }

        private void Min_bt_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AllSongs_bt_Click(object sender, EventArgs e)
        {
            SongsPanel.Controls.Clear();
            LoadAllSongsMenu();
            playcombo.Text = "Playlists";
            SongsLabel.Text = "ALL SONGS";
            DeletePlaylist_bt.Hide();
        }

        private void Playlists_bt_Click(object sender, EventArgs e)
        {
            playlists playlists = new playlists();
            playlists.Show();
        }

        public static int clicks = 0;
        public void Play_bt_Click(object sender, EventArgs e)
        {

            if (clicks == 1)
                Player_Slider.Value = 0;

            axWindowsMediaPlayer1.URL = "E:\\Instrumental\\ss.mp3";
            timer1.Start();
            clicks = 1;
            pictureBox5.Enabled = true;

        }

        private void Pause_bt_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            timer1.Stop();
            pictureBox5.Enabled = false;

        }

        private void Resume_bt_Click(object sender, EventArgs e)
        {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                timer1.Start();
                pictureBox5.Enabled = true;

        }

        private void Mute_bt_Click(object sender, EventArgs e)
        {
            Mute_bt.Hide();
            Speaker_bt.Show();
            Volume_Slider.Value = 0;
            axWindowsMediaPlayer1.settings.volume = 0;
        }

        private void Speaker_bt_Click(object sender, EventArgs e)
        {
            Speaker_bt.Hide();
            Mute_bt.Show();
            Volume_Slider.Value = 100;
            axWindowsMediaPlayer1.settings.volume = 100;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            
        }

        private void AddSongs_bt_Click(object sender, EventArgs e)
        {
            
        }

        private void AddSongs_bt_Click_1(object sender, EventArgs e)
        {
                    
            if (File.Exists("AllSongs.xml"))
            {
                FileStream fs = new FileStream("AllSongs.xml", FileMode.OpenOrCreate);
                XmlSerializer xs = new XmlSerializer(songs_list.GetType());
                songs_list = (List<Song>)xs.Deserialize(fs);
                fs.Close();
            }
            OpenFileDialog dia = new OpenFileDialog();
            if (dia.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                String strfilename = dia.FileName;
                string sourceFile = strfilename;
                songname = Path.GetFileName(sourceFile);
                string destinationFile = @"C:\Users\Mido\Desktop\Musically\My Playlist\My Playlist\Resources\AllSongs\" + songname;
                try
                {
                    File.Copy(sourceFile, Path.Combine(destinationFile), true);
                }
                catch (Exception)
                {
                    MessageBox.Show("We are very sorry , try to add another song");
                }
                mp3reader m = new mp3reader(destinationFile);
                Song c = m.GetTag();
                c.path = destinationFile;
                songs_list.Add(c);

                FileStream fs = new FileStream("AllSongs.xml", FileMode.OpenOrCreate);
                XmlSerializer xs = new XmlSerializer(songs_list.GetType());
                xs.Serialize(fs, songs_list);
                fs.Close();
                
            
                SongsPanel.Controls.Clear();
              
                names = new string[songs_list.Count];
                paths = new string[songs_list.Count];
                for (int i = 0; i < songs_list.Count; i++)
                {
                    string titleval = songs_list[i].name;                   
                    string pathval =songs_list[i].path;
                    sname = titleval;
                    path = pathval;
                    paths[i] = pathval;
                    names[i] = titleval;
                    User_controllers.Songaya ss = new User_controllers.Songaya();
                    ss.songnamelbl.Text = sname;
                    SongsPanel.Controls.Add(ss);
                }

            }
        }

        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            b AddPlayList = new b();
            AddPlayList.Show();
        }

        private void Playcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SongsLabel.Text = playcombo.Text;
            DeletePlaylist_bt.Show();

            SongsPanel.Controls.Clear();
            int x = 0;
            if (File.Exists("PlaylistsSongs.xml"))
            {

                XmlDocument doc = new XmlDocument();
                doc.Load("PlaylistsSongs.xml");
                XmlNodeList list = doc.GetElementsByTagName("playlistSong");
                paths = new string[list.Count];
                for (int i = 0; i < list.Count; i++)
                {
                    XmlNodeList child = list[i].ChildNodes;
                    if (child[4].InnerText == playcombo.SelectedItem.ToString())
                    {
                        //listBox1.Items.Add(child[0].InnerText);
                        User_controllers.SongayaInPlaylist s = new User_controllers.SongayaInPlaylist();
                        string name = child[0].InnerText;
                        s.songnamelbl.Text = name;

                        SongsPanel.Controls.Add(s);

                        paths[x] = child[3].InnerText;
                        x++;
                    }

                }
            }
        }

        private void DeletePlaylist_bt_Click(object sender, EventArgs e)
        {
            Delete d = new Delete();
            d.delete_playlist(playcombo.Text);
            LoadAllSongsMenu();
            LoadPlaylistsMenu();
            
        }

        private void BackToAllSongs_bt_Click(object sender, EventArgs e)
        {
            LoadAllSongsMenu();
            BackToAllSongs_bt.Hide();
        }

        private void SongsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Volume_Slider_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = Volume_Slider.Value;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
                Player_Slider.Value++;
        }
    }
}
