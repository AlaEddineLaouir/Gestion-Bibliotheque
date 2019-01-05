namespace BiblioUI
{
    partial class Ouvrage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dispo = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cherhcerOuvrage = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.nonDispo = new Bunifu.Framework.UI.BunifuImageButton();
            this.set = new Bunifu.Framework.UI.BunifuImageButton();
            this.add = new Bunifu.Framework.UI.BunifuImageButton();
            this.GridOuvrage = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.CodeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeOurage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThemeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitreCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuteurCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisponibleCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dispo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nonDispo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.set)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridOuvrage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dispo);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.cherhcerOuvrage);
            this.panel1.Controls.Add(this.nonDispo);
            this.panel1.Controls.Add(this.set);
            this.panel1.Controls.Add(this.add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 166);
            this.panel1.TabIndex = 1;
            // 
            // dispo
            // 
            this.dispo.BackColor = System.Drawing.Color.White;
            this.dispo.Image = global::BiblioUI.Properties.Resources.backup_icon;
            this.dispo.ImageActive = null;
            this.dispo.Location = new System.Drawing.Point(712, 6);
            this.dispo.Name = "dispo";
            this.dispo.Size = new System.Drawing.Size(71, 71);
            this.dispo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dispo.TabIndex = 5;
            this.dispo.TabStop = false;
            this.dispo.Zoom = 10;
            this.dispo.Click += new System.EventHandler(this.dispo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BiblioUI.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(355, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // cherhcerOuvrage
            // 
            this.cherhcerOuvrage.BorderColor = System.Drawing.Color.SeaGreen;
            this.cherhcerOuvrage.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cherhcerOuvrage.Location = new System.Drawing.Point(411, 114);
            this.cherhcerOuvrage.Name = "cherhcerOuvrage";
            this.cherhcerOuvrage.Size = new System.Drawing.Size(244, 33);
            this.cherhcerOuvrage.TabIndex = 3;
            this.cherhcerOuvrage.TextChanged += new System.EventHandler(this.bunifuCustomTextbox1_TextChanged);
            // 
            // nonDispo
            // 
            this.nonDispo.BackColor = System.Drawing.Color.White;
            this.nonDispo.Image = global::BiblioUI.Properties.Resources.close;
            this.nonDispo.ImageActive = null;
            this.nonDispo.Location = new System.Drawing.Point(559, 6);
            this.nonDispo.Name = "nonDispo";
            this.nonDispo.Size = new System.Drawing.Size(71, 71);
            this.nonDispo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.nonDispo.TabIndex = 2;
            this.nonDispo.TabStop = false;
            this.nonDispo.Zoom = 10;
            this.nonDispo.Click += new System.EventHandler(this.nonDispo_Click);
            // 
            // set
            // 
            this.set.BackColor = System.Drawing.Color.White;
            this.set.Image = global::BiblioUI.Properties.Resources.gear;
            this.set.ImageActive = null;
            this.set.Location = new System.Drawing.Point(391, 6);
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
            this.add.Location = new System.Drawing.Point(216, 5);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(71, 71);
            this.add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.add.TabIndex = 0;
            this.add.TabStop = false;
            this.add.Zoom = 10;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // GridOuvrage
            // 
            this.GridOuvrage.AllowUserToAddRows = false;
            this.GridOuvrage.AllowUserToDeleteRows = false;
            this.GridOuvrage.AllowUserToResizeColumns = false;
            this.GridOuvrage.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GridOuvrage.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.GridOuvrage.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.GridOuvrage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridOuvrage.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridOuvrage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridOuvrage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridOuvrage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeCol,
            this.TypeOurage,
            this.ThemeCol,
            this.TitreCol,
            this.AuteurCol,
            this.DisponibleCol});
            this.GridOuvrage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridOuvrage.DoubleBuffered = true;
            this.GridOuvrage.EnableHeadersVisualStyles = false;
            this.GridOuvrage.HeaderBgColor = System.Drawing.Color.SlateGray;
            this.GridOuvrage.HeaderForeColor = System.Drawing.Color.White;
            this.GridOuvrage.Location = new System.Drawing.Point(0, 166);
            this.GridOuvrage.Name = "GridOuvrage";
            this.GridOuvrage.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GridOuvrage.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridOuvrage.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.GridOuvrage.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SkyBlue;
            this.GridOuvrage.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.GridOuvrage.RowTemplate.Height = 40;
            this.GridOuvrage.Size = new System.Drawing.Size(969, 342);
            this.GridOuvrage.TabIndex = 2;
            // 
            // CodeCol
            // 
            this.CodeCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CodeCol.DataPropertyName = "1";
            this.CodeCol.HeaderText = "Code Ouvrage";
            this.CodeCol.Name = "CodeCol";
            this.CodeCol.ReadOnly = true;
            // 
            // TypeOurage
            // 
            this.TypeOurage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TypeOurage.DataPropertyName = "2";
            this.TypeOurage.HeaderText = "Type Ouvrage";
            this.TypeOurage.Name = "TypeOurage";
            this.TypeOurage.ReadOnly = true;
            // 
            // ThemeCol
            // 
            this.ThemeCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThemeCol.DataPropertyName = "3";
            this.ThemeCol.HeaderText = "Theme";
            this.ThemeCol.Name = "ThemeCol";
            this.ThemeCol.ReadOnly = true;
            // 
            // TitreCol
            // 
            this.TitreCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TitreCol.DataPropertyName = "5";
            this.TitreCol.HeaderText = "Titre";
            this.TitreCol.Name = "TitreCol";
            this.TitreCol.ReadOnly = true;
            // 
            // AuteurCol
            // 
            this.AuteurCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AuteurCol.DataPropertyName = "4";
            this.AuteurCol.HeaderText = "Auteur";
            this.AuteurCol.Name = "AuteurCol";
            this.AuteurCol.ReadOnly = true;
            // 
            // DisponibleCol
            // 
            this.DisponibleCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DisponibleCol.DataPropertyName = "6";
            this.DisponibleCol.HeaderText = "Disponible";
            this.DisponibleCol.Name = "DisponibleCol";
            this.DisponibleCol.ReadOnly = true;
            // 
            // Ouvrage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.GridOuvrage);
            this.Controls.Add(this.panel1);
            this.Name = "Ouvrage";
            this.Size = new System.Drawing.Size(969, 508);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dispo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nonDispo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.set)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridOuvrage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox cherhcerOuvrage;
        private Bunifu.Framework.UI.BunifuImageButton nonDispo;
        private Bunifu.Framework.UI.BunifuImageButton set;
        private Bunifu.Framework.UI.BunifuImageButton add;
        private Bunifu.Framework.UI.BunifuCustomDataGrid GridOuvrage;
        private Bunifu.Framework.UI.BunifuImageButton dispo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeOurage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThemeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitreCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuteurCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisponibleCol;
    }
}
