namespace BiblioUI
{
    partial class Etudiant
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chercherEtudiant = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.set = new Bunifu.Framework.UI.BunifuImageButton();
            this.add = new Bunifu.Framework.UI.BunifuImageButton();
            this.GridEtudiant = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.NomUtilisateurCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NemeroCarteCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrenomCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpecialiteCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NiveauCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.set)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridEtudiant)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.chercherEtudiant);
            this.panel1.Controls.Add(this.set);
            this.panel1.Controls.Add(this.add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 166);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BiblioUI.Properties.Resources.search__1_;
            this.pictureBox1.Location = new System.Drawing.Point(380, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // chercherEtudiant
            // 
            this.chercherEtudiant.BorderColor = System.Drawing.Color.SeaGreen;
            this.chercherEtudiant.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chercherEtudiant.Location = new System.Drawing.Point(436, 114);
            this.chercherEtudiant.Name = "chercherEtudiant";
            this.chercherEtudiant.Size = new System.Drawing.Size(244, 33);
            this.chercherEtudiant.TabIndex = 3;
            this.chercherEtudiant.TextChanged += new System.EventHandler(this.chercherEtudiant_TextChanged);
            // 
            // set
            // 
            this.set.BackColor = System.Drawing.Color.White;
            this.set.Image = global::BiblioUI.Properties.Resources.gear;
            this.set.ImageActive = null;
            this.set.Location = new System.Drawing.Point(580, 12);
            this.set.Name = "set";
            this.set.Size = new System.Drawing.Size(71, 71);
            this.set.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.set.TabIndex = 1;
            this.set.TabStop = false;
            this.set.Zoom = 10;
            this.set.Click += new System.EventHandler(this.set_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.White;
            this.add.Image = global::BiblioUI.Properties.Resources.add;
            this.add.ImageActive = null;
            this.add.Location = new System.Drawing.Point(405, 12);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(71, 71);
            this.add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.add.TabIndex = 0;
            this.add.TabStop = false;
            this.add.Zoom = 10;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // GridEtudiant
            // 
            this.GridEtudiant.AllowUserToAddRows = false;
            this.GridEtudiant.AllowUserToDeleteRows = false;
            this.GridEtudiant.AllowUserToOrderColumns = true;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GridEtudiant.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.GridEtudiant.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.GridEtudiant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridEtudiant.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridEtudiant.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.GridEtudiant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEtudiant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomUtilisateurCol,
            this.NemeroCarteCol,
            this.NomCol,
            this.PrenomCol,
            this.SpecialiteCol,
            this.NiveauCol,
            this.EmailCol});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.NullValue = "Vide";
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridEtudiant.DefaultCellStyle = dataGridViewCellStyle9;
            this.GridEtudiant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridEtudiant.DoubleBuffered = true;
            this.GridEtudiant.EnableHeadersVisualStyles = false;
            this.GridEtudiant.HeaderBgColor = System.Drawing.Color.SkyBlue;
            this.GridEtudiant.HeaderForeColor = System.Drawing.Color.White;
            this.GridEtudiant.Location = new System.Drawing.Point(0, 166);
            this.GridEtudiant.Name = "GridEtudiant";
            this.GridEtudiant.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GridEtudiant.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridEtudiant.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.GridEtudiant.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.GridEtudiant.RowTemplate.Height = 40;
            this.GridEtudiant.RowTemplate.ReadOnly = true;
            this.GridEtudiant.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.GridEtudiant.Size = new System.Drawing.Size(874, 307);
            this.GridEtudiant.TabIndex = 1;
            // 
            // NomUtilisateurCol
            // 
            this.NomUtilisateurCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomUtilisateurCol.DataPropertyName = "1";
            this.NomUtilisateurCol.HeaderText = "Nom Utilisateur";
            this.NomUtilisateurCol.Name = "NomUtilisateurCol";
            this.NomUtilisateurCol.ReadOnly = true;
            // 
            // NemeroCarteCol
            // 
            this.NemeroCarteCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NemeroCarteCol.DataPropertyName = "2";
            this.NemeroCarteCol.HeaderText = "Nemero Carte";
            this.NemeroCarteCol.Name = "NemeroCarteCol";
            this.NemeroCarteCol.ReadOnly = true;
            // 
            // NomCol
            // 
            this.NomCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomCol.DataPropertyName = "3";
            this.NomCol.HeaderText = "Nom";
            this.NomCol.Name = "NomCol";
            this.NomCol.ReadOnly = true;
            // 
            // PrenomCol
            // 
            this.PrenomCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PrenomCol.DataPropertyName = "4";
            this.PrenomCol.HeaderText = "Prenom";
            this.PrenomCol.Name = "PrenomCol";
            this.PrenomCol.ReadOnly = true;
            // 
            // SpecialiteCol
            // 
            this.SpecialiteCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SpecialiteCol.DataPropertyName = "5";
            this.SpecialiteCol.HeaderText = "Spécialité";
            this.SpecialiteCol.Name = "SpecialiteCol";
            this.SpecialiteCol.ReadOnly = true;
            // 
            // NiveauCol
            // 
            this.NiveauCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NiveauCol.DataPropertyName = "6";
            this.NiveauCol.HeaderText = "Niveau";
            this.NiveauCol.Name = "NiveauCol";
            this.NiveauCol.ReadOnly = true;
            // 
            // EmailCol
            // 
            this.EmailCol.DataPropertyName = "7";
            this.EmailCol.HeaderText = "Email";
            this.EmailCol.Name = "EmailCol";
            this.EmailCol.ReadOnly = true;
            // 
            // Etudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.GridEtudiant);
            this.Controls.Add(this.panel1);
            this.Name = "Etudiant";
            this.Size = new System.Drawing.Size(874, 473);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.set)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridEtudiant)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton add;
        private Bunifu.Framework.UI.BunifuImageButton set;
        private Bunifu.Framework.UI.BunifuCustomDataGrid GridEtudiant;
        private System.Windows.Forms.PictureBox pictureBox1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox chercherEtudiant;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomUtilisateurCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NemeroCarteCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrenomCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecialiteCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NiveauCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailCol;
    }
}
