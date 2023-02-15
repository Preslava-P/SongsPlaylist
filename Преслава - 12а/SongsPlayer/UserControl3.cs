using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SongsPlayer
{
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string video = "D:\\videos\\videoplayback.mp4";
            axWindowsMediaPlayer1.URL = video;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string video = "D:\\videos\\videoplayback3.mp4";
            axWindowsMediaPlayer2.URL = video;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string video = "D:\\videos\\videoplayback1.mp4";
            axWindowsMediaPlayer3.URL = video;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string video = "D:\\videos\\videoplayback2.mp4";
            axWindowsMediaPlayer4.URL = video;
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {
            
        }
    }
}
