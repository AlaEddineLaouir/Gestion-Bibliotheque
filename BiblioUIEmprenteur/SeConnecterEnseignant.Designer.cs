namespace BiblioUIEmprenteur
{
    partial class SeConnecterEnseignant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeConnecterEnseignant));
            this.add = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.motPasse = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.nomLable = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.titre = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.nomU = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.add)).BeginInit();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.White;
            this.add.Image = global::BiblioUIEmprenteur.Properties.Resources.Graphicloads_100_Flat_2_Check_1;
            this.add.ImageActive = null;
            this.add.Location = new System.Drawing.Point(312, 322);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(71, 71);
            this.add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.add.TabIndex = 51;
            this.add.TabStop = false;
            this.add.Zoom = 10;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(26, 240);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(135, 25);
            this.bunifuCustomLabel4.TabIndex = 50;
            this.bunifuCustomLabel4.Text = "Mot de Passe :";
            // 
            // motPasse
            // 
            this.motPasse.BorderColor = System.Drawing.Color.SeaGreen;
            this.motPasse.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motPasse.Location = new System.Drawing.Point(190, 237);
            this.motPasse.Name = "motPasse";
            this.motPasse.Size = new System.Drawing.Size(193, 33);
            this.motPasse.TabIndex = 49;
            // 
            // nomLable
            // 
            this.nomLable.AutoSize = true;
            this.nomLable.ForeColor = System.Drawing.Color.Red;
            this.nomLable.Location = new System.Drawing.Point(196, 187);
            this.nomLable.Name = "nomLable";
            this.nomLable.Size = new System.Drawing.Size(62, 13);
            this.nomLable.TabIndex = 48;
            this.nomLable.Text = "n\'existe pas";
            this.nomLable.Visible = false;
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.Location = new System.Drawing.Point(110, 32);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(199, 41);
            this.titre.TabIndex = 47;
            this.titre.Text = "Se Connecter";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(26, 154);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(158, 25);
            this.bunifuCustomLabel1.TabIndex = 46;
            this.bunifuCustomLabel1.Text = "Nom Utilisateur :";
            // 
            // nomU
            // 
            this.nomU.BorderColor = System.Drawing.Color.SeaGreen;
            this.nomU.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomU.Location = new System.Drawing.Point(190, 151);
            this.nomU.Name = "nomU";
            this.nomU.Size = new System.Drawing.Size(193, 33);
            this.nomU.TabIndex = 45;
            this.nomU.Leave += new System.EventHandler(this.nomU_Leave);
            // 
            // SeConnecterEnseignant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(409, 424);
            this.Controls.Add(this.add);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.motPasse);
            this.Controls.Add(this.nomLable);
            this.Controls.Add(this.titre);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.nomU);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SeConnecterEnseignant";
            this.Text = "SeConnecterEnseignant";
            ((System.ComponentModel.ISupportInitialize)(this.add)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton add;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox motPasse;
        private Bunifu.Framework.UI.BunifuCustomLabel nomLable;
        private Bunifu.Framework.UI.BunifuCustomLabel titre;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox nomU;
    }
}