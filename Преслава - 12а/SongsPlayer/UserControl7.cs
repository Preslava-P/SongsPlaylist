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
    public partial class UserControl7 : UserControl
    {
        public UserControl7()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                txtId.Text = listView1.SelectedItems[0].SubItems[0].Text;
                txtFirstName.Text = listView1.SelectedItems[0].SubItems[1].Text;
                txtLastName.Text = listView1.SelectedItems[0].SubItems[2].Text;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ListViewItem newItem = new ListViewItem(txtId.Text);
            newItem.SubItems.Add(txtFirstName.Text);
            newItem.SubItems.Add(txtLastName.Text);
            listView1.Items.Add(newItem);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].SubItems[0].Text = txtId.Text;
                listView1.SelectedItems[0].SubItems[1].Text = txtFirstName.Text;
                listView1.SelectedItems[0].SubItems[2].Text = txtLastName.Text;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }
    }
}
