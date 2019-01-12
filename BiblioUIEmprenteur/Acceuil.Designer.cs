namespace BiblioUIEmprenteur
{
    partial class Acceuil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acceuil));
            this.Authentification = new System.Windows.Forms.Panel();
            this.authentifiacationPanel1 = new BiblioUIEmprenteur.AuthentifiacationPanel();
            this.Top = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.espaceUtilisateur1 = new BiblioUIEmprenteur.EspaceUtilisateur();
            this.Authentification.SuspendLayout();
            this.Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Authentification
            // 
            this.Authentification.Controls.Add(this.espaceUtilisateur1);
            this.Authentification.Controls.Add(this.authentifiacationPanel1);
            this.Authentification.Controls.Add(this.Top);
            this.Authentification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Authentification.Location = new System.Drawing.Point(0, 0);
            this.Authentification.Name = "Authentification";
            this.Authentification.Size = new System.Drawing.Size(1284, 601);
            this.Authentification.TabIndex = 1;
            // 
            // authentifiacationPanel1
            // 
            this.authentifiacationPanel1.BackColor = System.Drawing.Color.White;
            this.authentifiacationPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authentifiacationPanel1.Location = new System.Drawing.Point(0, 98);
            this.authentifiacationPanel1.Name = "authentifiacationPanel1";
            this.authentifiacationPanel1.Size = new System.Drawing.Size(1284, 503);
            this.authentifiacationPanel1.TabIndex = 1;
            // 
            // Top
            // 
            this.Top.Controls.Add(this.pictureBox1);
            this.Top.Controls.Add(this.bunifuCustomLabel1);
            this.Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top.Location = new System.Drawing.Point(0, 0);
            this.Top.Name = "Top";
            this.Top.Size = new System.Drawing.Size(1284, 98);
            this.Top.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BiblioUIEmprenteur.Properties.Resources.books;
            this.pictureBox1.Location = new System.Drawing.Point(27, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(107, 25);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(1174, 45);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Bibliothéque Université Constantine 2 Abd El Hamide Mehri Departement NTIC";
            // 
            // espaceUtilisateur1
            // 
            this.espaceUtilisateur1.BackColor = System.Drawing.Color.White;
            this.espaceUtilisateur1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.espaceUtilisateur1.Location = new System.Drawing.Point(0, 98);
            this.espaceUtilisateur1.Name = "espaceUtilisateur1";
            this.espaceUtilisateur1.Size = new System.Drawing.Size(1284, 503);
            this.espaceUtilisateur1.TabIndex = 2;
            // 
            // Acceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 601);
            this.Controls.Add(this.Authentification);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1300, 640);
            this.MinimumSize = new System.Drawing.Size(1300, 640);
            this.Name = "Acceuil";
            this.Text = "Bibliotheque UC2";
            this.Load += new System.EventHandler(this.Acceuil_Load);
            this.Authentification.ResumeLayout(false);
            this.Top.ResumeLayout(false);
            this.Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Authentification;
        private System.Windows.Forms.Panel Top;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private AuthentifiacationPanel authentifiacationPanel1;
        private EspaceUtilisateur espaceUtilisateur1;
    }
}

