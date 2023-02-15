namespace SongsPlayer
{
    partial class User
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddSongs = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            this.userControl51 = new SongsPlayer.UserControl5();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnAddSongs);
            this.panel1.Controls.Add(this.Logout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Bisque;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 78);
            this.panel1.TabIndex = 0;
            // 
            // btnAddSongs
            // 
            this.btnAddSongs.BackColor = System.Drawing.Color.Coral;
            this.btnAddSongs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddSongs.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddSongs.Location = new System.Drawing.Point(10, 10);
            this.btnAddSongs.Name = "btnAddSongs";
            this.btnAddSongs.Size = new System.Drawing.Size(539, 54);
            this.btnAddSongs.TabIndex = 6;
            this.btnAddSongs.Text = "Update Playlist";
            this.btnAddSongs.UseVisualStyleBackColor = false;
            this.btnAddSongs.Click += new System.EventHandler(this.btnAddSongs_Click);
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.Color.Bisque;
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Logout.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Logout.ForeColor = System.Drawing.Color.Coral;
            this.Logout.Location = new System.Drawing.Point(663, 10);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(102, 44);
            this.Logout.TabIndex = 5;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.userControl51);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(779, 372);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(336, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome!";
            // 
            // openDialog
            // 
            this.openDialog.FileName = "openFileDialog1";
            // 
            // userControl51
            // 
            this.userControl51.BackColor = System.Drawing.Color.Coral;
            this.userControl51.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userControl51.ForeColor = System.Drawing.Color.Bisque;
            this.userControl51.Location = new System.Drawing.Point(0, 0);
            this.userControl51.Margin = new System.Windows.Forms.Padding(6);
            this.userControl51.Name = "userControl51";
            this.userControl51.Size = new System.Drawing.Size(779, 372);
            this.userControl51.TabIndex = 4;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(779, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Bisque;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button btnAddSongs;
        private System.Windows.Forms.OpenFileDialog openDialog;
        private System.Windows.Forms.Label label1;
        private UserControl5 userControl51;
    }
}