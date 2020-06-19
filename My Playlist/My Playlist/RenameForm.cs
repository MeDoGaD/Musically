using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Playlist
{
    public partial class RenameForm : Form
    {
        public RenameForm()
        {
            InitializeComponent();
        }
        public static string newn;
        private void Rename_bt_Click(object sender, EventArgs e)
        {
            Rename r = new Rename();
            r.rename_xml_name(newn,playnametxt.Text);
            this.Close();
        }
    }
}
