namespace BiblioUI
{
    partial class Enseignant
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomTextbox1 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.delete = new Bunifu.Framework.UI.BunifuImageButton();
            this.set = new Bunifu.Framework.UI.BunifuImageButton();
            this.add = new Bunifu.Framework.UI.BunifuImageButton();
            this.GridEnseignant = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.MatreculeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomUtilisateurCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrenomCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BannerCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.set)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridEnseignant)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.bunifuCustomTextbox1);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.set);
            this.panel1.Controls.Add(this.add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 166);
            this.panel1.TabIndex = 1;
            // 
            // bunifuCustomTextbox1
            // 
            this.bunifuCustomTextbox1.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextbox1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomTextbox1.Location = new System.Drawing.Point(383, 114);
            this.bunifuCustomTextbox1.Name = "bunifuCustomTextbox1";
            this.bunifuCustomTextbox1.Size = new System.Drawing.Size(244, 33);
            this.bunifuCustomTextbox1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BiblioUI.Properties.Resources.search__1_;
            this.pictureBox1.Location = new System.Drawing.Point(327, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.White;
            this.delete.Image = global::BiblioUI.Properties.Resources.close;
            this.delete.ImageActive = null;
            this.delete.Location = new System.Drawing.Point(570, 6);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(71, 71);
            this.delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.delete.TabIndex = 2;
            this.delete.TabStop = false;
            this.delete.Zoom = 10;
            // 
            // set
            // 
            this.set.BackColor = System.Drawing.Color.White;
            this.set.Image = global::BiblioUI.Properties.Resources.gear;
            this.set.ImageActive = null;
            this.set.Location = new System.Drawing.Point(402, 6);
            this.set.Name = "set";
            this.set.Size = new System.Drawing.Size(71, 71);
            this.set.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.set.TabIndex = 1;
            this.set.TabStop = false;
            this.set.Zoom = 10;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.White;
            this.add.Image = global::BiblioUI.Properties.Resources.add;
            this.add.ImageActive = null;
            this.add.Location = new System.Drawing.Point(227, 5);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(71, 71);
            this.add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.add.TabIndex = 0;
            this.add.TabStop = false;
            this.add.Zoom = 10;
            // 
            // GridEnseignant
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GridEnseignant.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridEnseignant.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.GridEnseignant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridEnseignant.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridEnseignant.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridEnseignant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEnseignant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MatreculeCol,
            this.NomUtilisateurCol,
            this.NomCol,
            this.PrenomCol,
            this.GradeCol,
            this.EmailCol,
            this.BannerCol});
            this.GridEnseignant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridEnseignant.DoubleBuffered = true;
            this.GridEnseignant.EnableHeadersVisualStyles = false;
            this.GridEnseignant.HeaderBgColor = System.Drawing.Color.SkyBlue;
            this.GridEnseignant.HeaderForeColor = System.Drawing.Color.White;
            this.GridEnseignant.Location = new System.Drawing.Point(0, 166);
            this.GridEnseignant.Name = "GridEnseignant";
            this.GridEnseignant.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GridEnseignant.Size = new System.Drawing.Size(953, 324);
            this.GridEnseignant.TabIndex = 2;
            // 
            // MatreculeCol
            // 
            this.MatreculeCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MatreculeCol.HeaderText = "Matrecule";
            this.MatreculeCol.Name = "MatreculeCol";
            this.MatreculeCol.ReadOnly = true;
            // 
            // NomUtilisateurCol
            // 
            this.NomUtilisateurCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomUtilisateurCol.HeaderText = "Nom Utilisateur";
            this.NomUtilisateurCol.Name = "NomUtilisateurCol";
            this.NomUtilisateurCol.ReadOnly = true;
            // 
            // NomCol
            // 
            this.NomCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomCol.HeaderText = "Nom";
            this.NomCol.Name = "NomCol";
            this.NomCol.ReadOnly = true;
            // 
            // PrenomCol
            // 
            this.PrenomCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PrenomCol.HeaderText = "Prenom";
            this.PrenomCol.Name = "PrenomCol";
            this.PrenomCol.ReadOnly = true;
            // 
            // GradeCol
            // 
            this.GradeCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GradeCol.HeaderText = "Grade";
            this.GradeCol.Name = "GradeCol";
            this.GradeCol.ReadOnly = true;
            // 
            // EmailCol
            // 
            this.EmailCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmailCol.HeaderText = "Email";
            this.EmailCol.Name = "EmailCol";
            this.EmailCol.ReadOnly = true;
            // 
            // BannerCol
            // 
            this.BannerCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BannerCol.HeaderText = "Banner";
            this.BannerCol.Name = "BannerCol";
            this.BannerCol.ReadOnly = true;
            // 
            // Enseignant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.GridEnseignant);
            this.Controls.Add(this.panel1);
            this.Name = "Enseignant";
            this.Size = new System.Drawing.Size(953, 490);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.set)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridEnseignant)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextbox1;
        private Bunifu.Framework.UI.BunifuImageButton delete;
        private Bunifu.Framework.UI.BunifuImageButton set;
        private Bunifu.Framework.UI.BunifuImageButton add;
        private Bunifu.Framework.UI.BunifuCustomDataGrid GridEnseignant;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatreculeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomUtilisateurCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrenomCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn BannerCol;
    }
}
