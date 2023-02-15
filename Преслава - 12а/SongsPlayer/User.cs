using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace SongsPlayer
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void btnAddStyle_Click(object sender, EventArgs e)
        {
        }

        private void btnAddSongs_Click(object sender, EventArgs e)
        {
            userControl51.Show();
            userControl51.BringToFront();
        }

        private void btnAddSingers_Click(object sender, EventArgs e)
        {
        }

        private void User_Load(object sender, EventArgs e)
        {
            userControl51.Hide();
        }
    }
}
