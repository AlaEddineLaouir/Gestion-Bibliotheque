namespace BiblioUIEmprenteur
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
            this.valider = new Bunifu.Framework.UI.BunifuImageButton();
            this.GridReservation = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.NumereCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateReservation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmprenteurCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodeOuvCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridReservation)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.valider);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1075, 130);
            this.panel1.TabIndex = 2;
            // 
            // valider
            // 
            this.valider.BackColor = System.Drawing.Color.White;
            this.valider.Image = global::BiblioUIEmprenteur.Properties.Resources.add;
            this.valider.ImageActive = null;
            this.valider.Location = new System.Drawing.Point(580, 25);
            this.valider.Name = "valider";
            this.valider.Size = new System.Drawing.Size(71, 71);
            this.valider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.valider.TabIndex = 1;
            this.valider.TabStop = false;
            this.valider.Zoom = 10;
            this.valider.Click += new System.EventHandler(this.valider_Click);
            // 
            // GridReservation
            // 
            this.GridReservation.AllowUserToAddRows = false;
            this.GridReservation.AllowUserToDeleteRows = false;
            this.GridReservation.AllowUserToOrderColumns = true;
            this.GridReservation.AllowUserToResizeColumns = false;
            this.GridReservation.AllowUserToResizeRows = false;
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
            this.GridReservation.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridReservation.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.GridReservation.RowTemplate.Height = 40;
            this.GridReservation.Size = new System.Drawing.Size(1075, 414);
            this.GridReservation.TabIndex = 3;
            // 
            // NumereCol
            // 
            this.NumereCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NumereCol.DataPropertyName = "1";
            this.NumereCol.HeaderText = "Numero Reservation";
            this.NumereCol.Name = "NumereCol";
            this.NumereCol.ReadOnly = true;
            // 
            // DateReservation
            // 
            this.DateReservation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateReservation.DataPropertyName = "2";
            this.DateReservation.HeaderText = "Date Reservation";
            this.DateReservation.Name = "DateReservation";
            this.DateReservation.ReadOnly = true;
            // 
            // EmprenteurCol
            // 
            this.EmprenteurCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmprenteurCol.DataPropertyName = "3";
            this.EmprenteurCol.HeaderText = "Emprenteur";
            this.EmprenteurCol.Name = "EmprenteurCol";
            this.EmprenteurCol.ReadOnly = true;
            // 
            // CodeOuvCol
            // 
            this.CodeOuvCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CodeOuvCol.DataPropertyName = "4";
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
            this.Size = new System.Drawing.Size(1075, 544);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.valider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridReservation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton valider;
        private Bunifu.Framework.UI.BunifuCustomDataGrid GridReservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumereCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateReservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmprenteurCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeOuvCol;
    }
}
