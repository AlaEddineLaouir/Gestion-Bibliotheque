namespace BiblioUI
{
    partial class Reservation
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
            this.delete = new Bunifu.Framework.UI.BunifuImageButton();
            this.set = new Bunifu.Framework.UI.BunifuImageButton();
            this.add = new Bunifu.Framework.UI.BunifuImageButton();
            this.GridReservation = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.NumereCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateReservation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmprenteurCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodeOuvCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.set)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridReservation)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.set);
            this.panel1.Controls.Add(this.add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 130);
            this.panel1.TabIndex = 1;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.White;
            this.delete.Image = global::BiblioUI.Properties.Resources.close;
            this.delete.ImageActive = null;
            this.delete.Location = new System.Drawing.Point(570, 24);
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
            this.set.Location = new System.Drawing.Point(402, 24);
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
            this.add.Location = new System.Drawing.Point(227, 23);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(71, 71);
            this.add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.add.TabIndex = 0;
            this.add.TabStop = false;
            this.add.Zoom = 10;
            // 
            // GridReservation
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GridReservation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridReservation.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.GridReservation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridReservation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridReservation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridReservation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumereCol,
            this.DateReservation,
            this.EmprenteurCol,
            this.CodeOuvCol});
            this.GridReservation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridReservation.DoubleBuffered = true;
            this.GridReservation.EnableHeadersVisualStyles = false;
            this.GridReservation.HeaderBgColor = System.Drawing.Color.SteelBlue;
            this.GridReservation.HeaderForeColor = System.Drawing.Color.White;
            this.GridReservation.Location = new System.Drawing.Point(0, 130);
            this.GridReservation.Name = "GridReservation";
            this.GridReservation.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GridReservation.Size = new System.Drawing.Size(944, 387);
            this.GridReservation.TabIndex = 2;
            // 
            // NumereCol
            // 
            this.NumereCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NumereCol.HeaderText = "Numero Reservation";
            this.NumereCol.Name = "NumereCol";
            this.NumereCol.ReadOnly = true;
            // 
            // DateReservation
            // 
            this.DateReservation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateReservation.HeaderText = "Date Reservation";
            this.DateReservation.Name = "DateReservation";
            this.DateReservation.ReadOnly = true;
            // 
            // EmprenteurCol
            // 
            this.EmprenteurCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmprenteurCol.HeaderText = "Emprenteur";
            this.EmprenteurCol.Name = "EmprenteurCol";
            this.EmprenteurCol.ReadOnly = true;
            // 
            // CodeOuvCol
            // 
            this.CodeOuvCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CodeOuvCol.HeaderText = "Code Ouvrage";
            this.CodeOuvCol.Name = "CodeOuvCol";
            this.CodeOuvCol.ReadOnly = true;
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.GridReservation);
            this.Controls.Add(this.panel1);
            this.Name = "Reservation";
            this.Size = new System.Drawing.Size(944, 517);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.set)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridReservation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton delete;
        private Bunifu.Framework.UI.BunifuImageButton set;
        private Bunifu.Framework.UI.BunifuImageButton add;
        private Bunifu.Framework.UI.BunifuCustomDataGrid GridReservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumereCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateReservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmprenteurCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeOuvCol;
    }
}
