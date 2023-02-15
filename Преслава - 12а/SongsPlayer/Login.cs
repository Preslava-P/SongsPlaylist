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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Preslava" && txtPassword.Text == "123")
            {
                User userForm = new User();
                userForm.Show();
            }
            else if (txtUsername.Text == "Preslava Petrova" && txtPassword.Text == "1234")
            {
                Admin adminForm = new Admin();
                adminForm.Show();
            }
            else
            {
                MessageBox.Show("Wrong username or password!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
