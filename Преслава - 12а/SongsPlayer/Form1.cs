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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
        }

        private void View_Click(object sender, EventArgs e)
        {
            ViewWithoutLogin viewForm = new ViewWithoutLogin();
            viewForm.Show();
        }

        private void openLogin_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
