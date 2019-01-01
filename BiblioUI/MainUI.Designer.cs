namespace BiblioUI
{
    partial class MainUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuTileButton4 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton3 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton2 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.emprenteur1 = new BiblioUI.Emprenteur();
            this.ouvrage1 = new BiblioUI.Ouvrage();
            this.reservation1 = new BiblioUI.Reservation();
            this.emprente1 = new BiblioUI.Emprente();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.bunifuTileButton4);
            this.panel1.Controls.Add(this.bunifuTileButton3);
            this.panel1.Controls.Add(this.bunifuTileButton2);
            this.panel1.Controls.Add(this.bunifuTileButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 601);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BiblioUI.Properties.Resources.books;
            this.pictureBox1.Location = new System.Drawing.Point(86, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuTileButton4
            // 
            this.bunifuTileButton4.BackColor = System.Drawing.Color.Teal;
            this.bunifuTileButton4.color = System.Drawing.Color.Teal;
            this.bunifuTileButton4.colorActive = System.Drawing.Color.Teal;
            this.bunifuTileButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton4.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton4.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton4.Image = global::BiblioUI.Properties.Resources.rent;
            this.bunifuTileButton4.ImagePosition = 0;
            this.bunifuTileButton4.ImageZoom = 50;
            this.bunifuTileButton4.LabelPosition = 41;
            this.bunifuTileButton4.LabelText = "Emprente";
            this.bunifuTileButton4.Location = new System.Drawing.Point(1, 464);
            this.bunifuTileButton4.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton4.Name = "bunifuTileButton4";
            this.bunifuTileButton4.Size = new System.Drawing.Size(220, 136);
            this.bunifuTileButton4.TabIndex = 5;
            this.bunifuTileButton4.Click += new System.EventHandler(this.bunifuTileButton4_Click);
            // 
            // bunifuTileButton3
            // 
            this.bunifuTileButton3.BackColor = System.Drawing.Color.SteelBlue;
            this.bunifuTileButton3.color = System.Drawing.Color.SteelBlue;
            this.bunifuTileButton3.colorActive = System.Drawing.Color.SteelBlue;
            this.bunifuTileButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton3.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton3.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton3.Image = global::BiblioUI.Properties.Resources.reserved;
            this.bunifuTileButton3.ImagePosition = 0;
            this.bunifuTileButton3.ImageZoom = 50;
            this.bunifuTileButton3.LabelPosition = 41;
            this.bunifuTileButton3.LabelText = "Reservation";
            this.bunifuTileButton3.Location = new System.Drawing.Point(1, 328);
            this.bunifuTileButton3.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton3.Name = "bunifuTileButton3";
            this.bunifuTileButton3.Size = new System.Drawing.Size(220, 136);
            this.bunifuTileButton3.TabIndex = 4;
            this.bunifuTileButton3.Click += new System.EventHandler(this.bunifuTileButton3_Click);
            // 
            // bunifuTileButton2
            // 
            this.bunifuTileButton2.BackColor = System.Drawing.Color.SlateGray;
            this.bunifuTileButton2.color = System.Drawing.Color.SlateGray;
            this.bunifuTileButton2.colorActive = System.Drawing.Color.SlateGray;
            this.bunifuTileButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton2.Image = global::BiblioUI.Properties.Resources.library;
            this.bunifuTileButton2.ImagePosition = 0;
            this.bunifuTileButton2.ImageZoom = 50;
            this.bunifuTileButton2.LabelPosition = 41;
            this.bunifuTileButton2.LabelText = "Ouvrage";
            this.bunifuTileButton2.Location = new System.Drawing.Point(1, 192);
            this.bunifuTileButton2.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton2.Name = "bunifuTileButton2";
            this.bunifuTileButton2.Size = new System.Drawing.Size(220, 136);
            this.bunifuTileButton2.TabIndex = 3;
            this.bunifuTileButton2.Click += new System.EventHandler(this.bunifuTileButton2_Click);
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.SkyBlue;
            this.bunifuTileButton1.color = System.Drawing.Color.SkyBlue;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.SkyBlue;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = global::BiblioUI.Properties.Resources.reading;
            this.bunifuTileButton1.ImagePosition = 0;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 41;
            this.bunifuTileButton1.LabelText = "Emprenteur";
            this.bunifuTileButton1.Location = new System.Drawing.Point(1, 56);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(220, 136);
            this.bunifuTileButton1.TabIndex = 2;
            this.bunifuTileButton1.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.panel2.Controls.Add(this.bunifuCustomLabel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(222, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1062, 57);
            this.panel2.TabIndex = 1;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(4, 9);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(982, 37);
            this.bunifuCustomLabel2.TabIndex = 2;
            this.bunifuCustomLabel2.Text = "Bibliothéque Université Constantine 2 Abd El Hamide Mehri Departement NTIC";
            // 
            // emprenteur1
            // 
            this.emprenteur1.BackColor = System.Drawing.Color.White;
            this.emprenteur1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emprenteur1.Location = new System.Drawing.Point(222, 57);
            this.emprenteur1.Name = "emprenteur1";
            this.emprenteur1.Size = new System.Drawing.Size(1062, 544);
            this.emprenteur1.TabIndex = 2;
            // 
            // ouvrage1
            // 
            this.ouvrage1.BackColor = System.Drawing.Color.White;
            this.ouvrage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ouvrage1.Location = new System.Drawing.Point(222, 57);
            this.ouvrage1.Name = "ouvrage1";
            this.ouvrage1.Size = new System.Drawing.Size(1062, 544);
            this.ouvrage1.TabIndex = 3;
            // 
            // reservation1
            // 
            this.reservation1.BackColor = System.Drawing.Color.White;
            this.reservation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reservation1.Location = new System.Drawing.Point(222, 57);
            this.reservation1.Name = "reservation1";
            this.reservation1.Size = new System.Drawing.Size(1062, 544);
            this.reservation1.TabIndex = 4;
            // 
            // emprente1
            // 
            this.emprente1.BackColor = System.Drawing.Color.White;
            this.emprente1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emprente1.Location = new System.Drawing.Point(222, 57);
            this.emprente1.Name = "emprente1";
            this.emprente1.Size = new System.Drawing.Size(1062, 544);
            this.emprente1.TabIndex = 5;
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 601);
            this.Controls.Add(this.emprente1);
            this.Controls.Add(this.reservation1);
            this.Controls.Add(this.ouvrage1);
            this.Controls.Add(this.emprenteur1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1300, 640);
            this.MinimumSize = new System.Drawing.Size(1300, 640);
            this.Name = "MainUI";
            this.Text = "Univ Bibliotheque";
            this.Load += new System.EventHandler(this.MainUI_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton3;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton2;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Emprenteur emprenteur1;
        private Ouvrage ouvrage1;
        private Reservation reservation1;
        private Emprente emprente1;
    }
}