namespace BiblioUIEmprenteur
{
    partial class AjouterReservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjouterReservation));
            this.codeLable = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.titre = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.code = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.add = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.add)).BeginInit();
            this.SuspendLayout();
            // 
            // codeLable
            // 
            this.codeLable.AutoSize = true;
            this.codeLable.ForeColor = System.Drawing.Color.Red;
            this.codeLable.Location = new System.Drawing.Point(193, 129);
            this.codeLable.Name = "codeLable";
            this.codeLable.Size = new System.Drawing.Size(62, 13);
            this.codeLable.TabIndex = 45;
            this.codeLable.Text = "n\'existe pas";
            this.codeLable.Visible = false;
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.Location = new System.Drawing.Point(92, 16);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(261, 41);
            this.titre.TabIndex = 43;
            this.titre.Text = "Ajouter Emprente";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(23, 96);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(144, 25);
            this.bunifuCustomLabel1.TabIndex = 42;
            this.bunifuCustomLabel1.Text = "Code Ouvrage :";
            // 
            // code
            // 
            this.code.BorderColor = System.Drawing.Color.SeaGreen;
            this.code.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.code.Location = new System.Drawing.Point(187, 93);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(193, 33);
            this.code.TabIndex = 41;
            this.code.TextChanged += new System.EventHandler(this.code_TextChanged);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.White;
            this.add.Image = global::BiblioUIEmprenteur.Properties.Resources.add;
            this.add.ImageActive = null;
            this.add.Location = new System.Drawing.Point(382, 164);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(71, 71);
            this.add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.add.TabIndex = 44;
            this.add.TabStop = false;
            this.add.Zoom = 10;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // AjouterReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(474, 253);
            this.Controls.Add(this.codeLable);
            this.Controls.Add(this.add);
            this.Controls.Add(this.titre);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.code);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AjouterReservation";
            this.Text = "AjouterReservation";
            ((System.ComponentModel.ISupportInitialize)(this.add)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel codeLable;
        private Bunifu.Framework.UI.BunifuImageButton add;
        private Bunifu.Framework.UI.BunifuCustomLabel titre;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox code;
    }
}