namespace BiblioUIEmprenteur
{
    partial class ModifierProfilEnseignant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifierProfilEnseignant));
            this.add = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.email = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.grade = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.prenom = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.nom = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.matLable = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.mat = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.nomLable = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.nomU = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.titre = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.motPasse = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.add)).BeginInit();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.White;
            this.add.Image = global::BiblioUIEmprenteur.Properties.Resources.gear;
            this.add.ImageActive = null;
            this.add.Location = new System.Drawing.Point(681, 404);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(71, 71);
            this.add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.add.TabIndex = 71;
            this.add.TabStop = false;
            this.add.Zoom = 10;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(44, 268);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(69, 25);
            this.bunifuCustomLabel7.TabIndex = 70;
            this.bunifuCustomLabel7.Text = "Email :";
            // 
            // email
            // 
            this.email.BorderColor = System.Drawing.Color.SeaGreen;
            this.email.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(205, 265);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(196, 33);
            this.email.TabIndex = 69;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(44, 332);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(73, 25);
            this.bunifuCustomLabel6.TabIndex = 68;
            this.bunifuCustomLabel6.Text = "Grade :";
            // 
            // grade
            // 
            this.grade.AutoCompleteCustomSource.AddRange(new string[] {
            "L1",
            "L2",
            "L3",
            "M1",
            "M2",
            "D1",
            "D2",
            "D3"});
            this.grade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.grade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.grade.BorderColor = System.Drawing.Color.SeaGreen;
            this.grade.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grade.Location = new System.Drawing.Point(205, 329);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(196, 33);
            this.grade.TabIndex = 67;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(441, 271);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(89, 25);
            this.bunifuCustomLabel3.TabIndex = 66;
            this.bunifuCustomLabel3.Text = "Prenom :";
            // 
            // prenom
            // 
            this.prenom.BorderColor = System.Drawing.Color.SeaGreen;
            this.prenom.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenom.Location = new System.Drawing.Point(588, 268);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(176, 33);
            this.prenom.TabIndex = 65;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(441, 213);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(65, 25);
            this.bunifuCustomLabel2.TabIndex = 64;
            this.bunifuCustomLabel2.Text = "Nom :";
            // 
            // nom
            // 
            this.nom.BorderColor = System.Drawing.Color.SeaGreen;
            this.nom.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom.Location = new System.Drawing.Point(588, 210);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(176, 33);
            this.nom.TabIndex = 63;
            // 
            // matLable
            // 
            this.matLable.AutoSize = true;
            this.matLable.ForeColor = System.Drawing.Color.Red;
            this.matLable.Location = new System.Drawing.Point(594, 172);
            this.matLable.Name = "matLable";
            this.matLable.Size = new System.Drawing.Size(59, 13);
            this.matLable.TabIndex = 62;
            this.matLable.Text = "deja utiliser";
            this.matLable.Visible = false;
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(441, 139);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(109, 25);
            this.bunifuCustomLabel9.TabIndex = 61;
            this.bunifuCustomLabel9.Text = "Matrecule :";
            // 
            // mat
            // 
            this.mat.BorderColor = System.Drawing.Color.SeaGreen;
            this.mat.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mat.Location = new System.Drawing.Point(588, 136);
            this.mat.Name = "mat";
            this.mat.Size = new System.Drawing.Size(176, 33);
            this.mat.TabIndex = 60;
            this.mat.Leave += new System.EventHandler(this.mat_Leave);
            // 
            // nomLable
            // 
            this.nomLable.AutoSize = true;
            this.nomLable.ForeColor = System.Drawing.Color.Red;
            this.nomLable.Location = new System.Drawing.Point(214, 172);
            this.nomLable.Name = "nomLable";
            this.nomLable.Size = new System.Drawing.Size(59, 13);
            this.nomLable.TabIndex = 59;
            this.nomLable.Text = "deja utiliser";
            this.nomLable.Visible = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(44, 139);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(158, 25);
            this.bunifuCustomLabel1.TabIndex = 58;
            this.bunifuCustomLabel1.Text = "Nom Utilisateur :";
            // 
            // nomU
            // 
            this.nomU.BorderColor = System.Drawing.Color.SeaGreen;
            this.nomU.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomU.Location = new System.Drawing.Point(208, 136);
            this.nomU.Name = "nomU";
            this.nomU.Size = new System.Drawing.Size(193, 33);
            this.nomU.TabIndex = 57;
            this.nomU.Leave += new System.EventHandler(this.nomU_Leave);
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.Location = new System.Drawing.Point(298, 23);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(295, 41);
            this.titre.TabIndex = 56;
            this.titre.Text = "Modifier Enseignant";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(44, 210);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(135, 25);
            this.bunifuCustomLabel4.TabIndex = 73;
            this.bunifuCustomLabel4.Text = "Mot de Passe :";
            // 
            // motPasse
            // 
            this.motPasse.BorderColor = System.Drawing.Color.SeaGreen;
            this.motPasse.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motPasse.Location = new System.Drawing.Point(208, 207);
            this.motPasse.Name = "motPasse";
            this.motPasse.Size = new System.Drawing.Size(193, 33);
            this.motPasse.TabIndex = 72;
            // 
            // ModifierProfilEnseignant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(808, 498);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.motPasse);
            this.Controls.Add(this.add);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.email);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.grade);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.matLable);
            this.Controls.Add(this.bunifuCustomLabel9);
            this.Controls.Add(this.mat);
            this.Controls.Add(this.nomLable);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.nomU);
            this.Controls.Add(this.titre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModifierProfilEnseignant";
            this.Text = "ModifierProfilEnseignant";
            ((System.ComponentModel.ISupportInitialize)(this.add)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton add;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox email;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox grade;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox prenom;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox nom;
        private Bunifu.Framework.UI.BunifuCustomLabel matLable;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox mat;
        private Bunifu.Framework.UI.BunifuCustomLabel nomLable;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox nomU;
        private Bunifu.Framework.UI.BunifuCustomLabel titre;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox motPasse;
    }
}