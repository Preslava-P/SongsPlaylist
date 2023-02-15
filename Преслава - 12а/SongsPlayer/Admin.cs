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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            userControl71.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl71.Show();
            userControl71.BringToFront();
        }
    }
}
