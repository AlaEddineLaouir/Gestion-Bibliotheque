namespace BiblioUIEmprenteur
{
    partial class Emprente
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
            this.GridEmprente = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.NumereCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateEmprente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmprenteurCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodeOuvCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridEmprente)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1140, 152);
            this.panel1.TabIndex = 0;
            // 
            // GridEmprente
            // 
            this.GridEmprente.AllowUserToAddRows = false;
            this.GridEmprente.AllowUserToDeleteRows = false;
            this.GridEmprente.AllowUserToResizeColumns = false;
            this.GridEmprente.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GridEmprente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridEmprente.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.GridEmprente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridEmprente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridEmprente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridEmprente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEmprente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumereCol,
            this.DateEmprente,
            this.EmprenteurCol,
            this.CodeOuvCol});
            this.GridEmprente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridEmprente.DoubleBuffered = true;
            this.GridEmprente.EnableHeadersVisualStyles = false;
            this.GridEmprente.HeaderBgColor = System.Drawing.Color.Teal;
            this.GridEmprente.HeaderForeColor = System.Drawing.Color.White;
            this.GridEmprente.Location = new System.Drawing.Point(0, 152);
            this.GridEmprente.Name = "GridEmprente";
            this.GridEmprente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GridEmprente.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridEmprente.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.GridEmprente.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.GridEmprente.RowTemplate.Height = 40;
            this.GridEmprente.Size = new System.Drawing.Size(1140, 373);
            this.GridEmprente.TabIndex = 4;
            // 
            // NumereCol
            // 
            this.NumereCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NumereCol.DataPropertyName = "1";
            this.NumereCol.HeaderText = "Numero Reservation";
            this.NumereCol.Name = "NumereCol";
            this.NumereCol.ReadOnly = true;
            // 
            // DateEmprente
            // 
            this.DateEmprente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateEmprente.DataPropertyName = "2";
            this.DateEmprente.HeaderText = "Date Emprente";
            this.DateEmprente.Name = "DateEmprente";
            this.DateEmprente.ReadOnly = true;
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
            // Emprente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.GridEmprente);
            this.Controls.Add(this.panel1);
            this.Name = "Emprente";
            this.Size = new System.Drawing.Size(1140, 525);
            ((System.ComponentModel.ISupportInitialize)(this.GridEmprente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid GridEmprente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumereCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateEmprente;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmprenteurCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeOuvCol;
    }
}
