namespace SongsPlayer
{
    partial class ViewWithoutLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewWithoutLogin));
            this.Nav = new System.Windows.Forms.Panel();
            this.Home = new System.Windows.Forms.Button();
            this.Songs = new System.Windows.Forms.Button();
            this.Singers = new System.Windows.Forms.Button();
            this.Style = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            this.userControl21 = new SongsPlayer.UserControl2();
            this.userControl11 = new SongsPlayer.UserControl1();
            this.userControl34 = new SongsPlayer.UserControl3();
            this.userControl33 = new SongsPlayer.UserControl3();
            this.userControl31 = new SongsPlayer.UserControl3();
            this.Nav.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nav
            // 
            this.Nav.BackColor = System.Drawing.Color.Bisque;
            this.Nav.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Nav.Controls.Add(this.Home);
            this.Nav.Controls.Add(this.Songs);
            this.Nav.Controls.Add(this.Singers);
            this.Nav.Controls.Add(this.Style);
            this.Nav.Location = new System.Drawing.Point(0, 0);
            this.Nav.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Nav.Name = "Nav";
            this.Nav.Size = new System.Drawing.Size(232, 452);
            this.Nav.TabIndex = 1;
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.PapayaWhip;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Home.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Home.ForeColor = System.Drawing.Color.Coral;
            this.Home.Location = new System.Drawing.Point(18, 30);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(198, 55);
            this.Home.TabIndex = 4;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click_1);
            // 
            // Songs
            // 
            this.Songs.BackColor = System.Drawing.Color.Coral;
            this.Songs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Songs.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Songs.ForeColor = System.Drawing.Color.Bisque;
            this.Songs.Location = new System.Drawing.Point(33, 354);
            this.Songs.Name = "Songs";
            this.Songs.Size = new System.Drawing.Size(164, 71);
            this.Songs.TabIndex = 3;
            this.Songs.Text = "Songs";
            this.Songs.UseVisualStyleBackColor = false;
            this.Songs.Click += new System.EventHandler(this.Songs_Click);
            // 
            // Singers
            // 
            this.Singers.BackColor = System.Drawing.Color.Coral;
            this.Singers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Singers.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Singers.ForeColor = System.Drawing.Color.Bisque;
            this.Singers.Location = new System.Drawing.Point(33, 245);
            this.Singers.Name = "Singers";
            this.Singers.Size = new System.Drawing.Size(164, 71);
            this.Singers.TabIndex = 2;
            this.Singers.Text = "Singers";
            this.Singers.UseVisualStyleBackColor = false;
            this.Singers.Click += new System.EventHandler(this.Singers_Click);
            // 
            // Style
            // 
            this.Style.BackColor = System.Drawing.Color.Coral;
            this.Style.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Style.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Style.ForeColor = System.Drawing.Color.Bisque;
            this.Style.Location = new System.Drawing.Point(33, 142);
            this.Style.Name = "Style";
            this.Style.Size = new System.Drawing.Size(164, 71);
            this.Style.TabIndex = 1;
            this.Style.Text = "Musical Styles";
            this.Style.UseVisualStyleBackColor = false;
            this.Style.Click += new System.EventHandler(this.Style_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.userControl11);
            this.panel1.Controls.Add(this.userControl34);
            this.panel1.Controls.Add(this.userControl33);
            this.panel1.Controls.Add(this.userControl21);
            this.panel1.Location = new System.Drawing.Point(233, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 452);
            this.panel1.TabIndex = 2;
            // 
            // openDialog
            // 
            this.openDialog.FileName = "openFileDialog1";
            // 
            // userControl21
            // 
            this.userControl21.BackColor = System.Drawing.Color.Coral;
            this.userControl21.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userControl21.ForeColor = System.Drawing.Color.Bisque;
            this.userControl21.Location = new System.Drawing.Point(-3, -2);
            this.userControl21.Margin = new System.Windows.Forms.Padding(6);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(548, 452);
            this.userControl21.TabIndex = 2;
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.Coral;
            this.userControl11.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userControl11.ForeColor = System.Drawing.Color.Bisque;
            this.userControl11.Location = new System.Drawing.Point(-2, -2);
            this.userControl11.Margin = new System.Windows.Forms.Padding(6);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(548, 452);
            this.userControl11.TabIndex = 1;
            // 
            // userControl34
            // 
            this.userControl34.BackColor = System.Drawing.Color.Coral;
            this.userControl34.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControl34.ForeColor = System.Drawing.Color.Bisque;
            this.userControl34.Location = new System.Drawing.Point(-2, -2);
            this.userControl34.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userControl34.Name = "userControl34";
            this.userControl34.Size = new System.Drawing.Size(411, 367);
            this.userControl34.TabIndex = 5;
            // 
            // userControl33
            // 
            this.userControl33.BackColor = System.Drawing.Color.Coral;
            this.userControl33.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControl33.ForeColor = System.Drawing.Color.Bisque;
            this.userControl33.Location = new System.Drawing.Point(-3, -2);
            this.userControl33.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userControl33.Name = "userControl33";
            this.userControl33.Size = new System.Drawing.Size(549, 452);
            this.userControl33.TabIndex = 4;
            // 
            // userControl31
            // 
            this.userControl31.BackColor = System.Drawing.Color.Coral;
            this.userControl31.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControl31.ForeColor = System.Drawing.Color.Bisque;
            this.userControl31.Location = new System.Drawing.Point(-2, -2);
            this.userControl31.Margin = new System.Windows.Forms.Padding(6);
            this.userControl31.Name = "userControl31";
            this.userControl31.Size = new System.Drawing.Size(548, 452);
            this.userControl31.TabIndex = 3;
            // 
            // ViewWithoutLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Nav);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewWithoutLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Songs ";
            this.Load += new System.EventHandler(this.ViewWithoutLogin_Load);
            this.Nav.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Nav;
        private System.Windows.Forms.Button Songs;
        private System.Windows.Forms.Button Singers;
        private System.Windows.Forms.Button Style;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog openDialog;
        private System.Windows.Forms.Button Home;
        private UserControl1 userControl11;
        private UserControl3 userControl31;
        private UserControl2 userControl21;
        private UserControl3 userControl33;
        private UserControl3 userControl34;
    }
}