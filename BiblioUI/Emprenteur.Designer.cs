namespace BiblioUI
{
    partial class Emprenteur
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Slide = new System.Windows.Forms.Panel();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton2 = new Bunifu.Framework.UI.BunifuTileButton();
            this.enseignant1 = new BiblioUI.Enseignant();
            this.etudiant1 = new BiblioUI.Etudiant();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Slide);
            this.panel1.Controls.Add(this.bunifuTileButton1);
            this.panel1.Controls.Add(this.bunifuTileButton2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1101, 137);
            this.panel1.TabIndex = 0;
            // 
            // Slide
            // 
            this.Slide.BackColor = System.Drawing.Color.Silver;
            this.Slide.Location = new System.Drawing.Point(701, 125);
            this.Slide.Name = "Slide";
            this.Slide.Size = new System.Drawing.Size(286, 6);
            this.Slide.TabIndex = 3;
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.SkyBlue;
            this.bunifuTileButton1.color = System.Drawing.Color.SkyBlue;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.SkyBlue;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = global::BiblioUI.Properties.Resources.student;
            this.bunifuTileButton1.ImagePosition = 0;
            this.bunifuTileButton1.ImageZoom = 40;
            this.bunifuTileButton1.LabelPosition = 41;
            this.bunifuTileButton1.LabelText = "Etudiant";
            this.bunifuTileButton1.Location = new System.Drawing.Point(137, 15);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(232, 105);
            this.bunifuTileButton1.TabIndex = 2;
            this.bunifuTileButton1.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            // 
            // bunifuTileButton2
            // 
            this.bunifuTileButton2.BackColor = System.Drawing.Color.SkyBlue;
            this.bunifuTileButton2.color = System.Drawing.Color.SkyBlue;
            this.bunifuTileButton2.colorActive = System.Drawing.Color.SkyBlue;
            this.bunifuTileButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton2.Image = global::BiblioUI.Properties.Resources.teacher;
            this.bunifuTileButton2.ImagePosition = 0;
            this.bunifuTileButton2.ImageZoom = 40;
            this.bunifuTileButton2.LabelPosition = 41;
            this.bunifuTileButton2.LabelText = "Enseignant";
            this.bunifuTileButton2.Location = new System.Drawing.Point(728, 15);
            this.bunifuTileButton2.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton2.Name = "bunifuTileButton2";
            this.bunifuTileButton2.Size = new System.Drawing.Size(232, 105);
            this.bunifuTileButton2.TabIndex = 1;
            this.bunifuTileButton2.Click += new System.EventHandler(this.bunifuTileButton2_Click);
            // 
            // enseignant1
            // 
            this.enseignant1.BackColor = System.Drawing.Color.White;
            this.enseignant1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enseignant1.Location = new System.Drawing.Point(0, 137);
            this.enseignant1.Name = "enseignant1";
            this.enseignant1.Size = new System.Drawing.Size(1101, 417);
            this.enseignant1.TabIndex = 2;
            // 
            // etudiant1
            // 
            this.etudiant1.BackColor = System.Drawing.Color.White;
            this.etudiant1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.etudiant1.Location = new System.Drawing.Point(0, 137);
            this.etudiant1.Name = "etudiant1";
            this.etudiant1.Size = new System.Drawing.Size(1101, 417);
            this.etudiant1.TabIndex = 1;
            // 
            // Emprenteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.enseignant1);
            this.Controls.Add(this.etudiant1);
            this.Controls.Add(this.panel1);
            this.Name = "Emprenteur";
            this.Size = new System.Drawing.Size(1101, 554);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton2;
        private System.Windows.Forms.Panel Slide;
        private Etudiant etudiant1;
        private Enseignant enseignant1;
    }
}
