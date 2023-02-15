namespace SongsPlayer
{
    partial class Songs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblOpera = new System.Windows.Forms.Label();
            this.Pop = new System.Windows.Forms.Label();
            this.Chalga = new System.Windows.Forms.Label();
            this.Folklor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOpera
            // 
            this.lblOpera.AutoSize = true;
            this.lblOpera.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblOpera.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOpera.ForeColor = System.Drawing.Color.PapayaWhip;
            this.lblOpera.Location = new System.Drawing.Point(72, 26);
            this.lblOpera.Name = "lblOpera";
            this.lblOpera.Size = new System.Drawing.Size(61, 25);
            this.lblOpera.TabIndex = 10;
            this.lblOpera.Text = "Opera";
            // 
            // Pop
            // 
            this.Pop.AutoSize = true;
            this.Pop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Pop.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pop.ForeColor = System.Drawing.Color.PapayaWhip;
            this.Pop.Location = new System.Drawing.Point(396, 43);
            this.Pop.Name = "Pop";
            this.Pop.Size = new System.Drawing.Size(44, 25);
            this.Pop.TabIndex = 11;
            this.Pop.Text = "Pop";
            // 
            // Chalga
            // 
            this.Chalga.AutoSize = true;
            this.Chalga.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Chalga.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Chalga.ForeColor = System.Drawing.Color.PapayaWhip;
            this.Chalga.Location = new System.Drawing.Point(61, 273);
            this.Chalga.Name = "Chalga";
            this.Chalga.Size = new System.Drawing.Size(82, 25);
            this.Chalga.TabIndex = 12;
            this.Chalga.Text = "PopFolk";
            // 
            // Folklor
            // 
            this.Folklor.AutoSize = true;
            this.Folklor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Folklor.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Folklor.ForeColor = System.Drawing.Color.PapayaWhip;
            this.Folklor.Location = new System.Drawing.Point(387, 284);
            this.Folklor.Name = "Folklor";
            this.Folklor.Size = new System.Drawing.Size(72, 25);
            this.Folklor.TabIndex = 13;
            this.Folklor.Text = "Folklor";
            // 
            // Songs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.Controls.Add(this.Folklor);
            this.Controls.Add(this.Chalga);
            this.Controls.Add(this.Pop);
            this.Controls.Add(this.lblOpera);
            this.Name = "Songs";
            this.Size = new System.Drawing.Size(548, 452);
            this.Load += new System.EventHandler(this.Songs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOpera;
        private System.Windows.Forms.Label Pop;
        private System.Windows.Forms.Label Chalga;
        private System.Windows.Forms.Label Folklor;
    }
}
