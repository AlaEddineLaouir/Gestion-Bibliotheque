namespace BiblioUI
{
    partial class AjouterEmprinte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjouterEmprinte));
            this.codeLable = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.add = new Bunifu.Framework.UI.BunifuImageButton();
            this.titre = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.code = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.nomLable = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.nomU = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.add)).BeginInit();
            this.SuspendLayout();
            // 
            // codeLable
            // 
            this.codeLable.AutoSize = true;
            this.codeLable.ForeColor = System.Drawing.Color.Red;
            this.codeLable.Location = new System.Drawing.Point(188, 122);
            this.codeLable.Name = "codeLable";
            this.codeLable.Size = new System.Drawing.Size(62, 13);
            this.codeLable.TabIndex = 37;
            this.codeLable.Text = "n\'existe pas";
            this.codeLable.Visible = false;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.White;
            this.add.Image = global::BiblioUI.Properties.Resources.add;
            this.add.ImageActive = null;
            this.add.Location = new System.Drawing.Point(376, 265);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(71, 71);
            this.add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.add.TabIndex = 36;
            this.add.TabStop = false;
            this.add.Zoom = 10;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.Location = new System.Drawing.Point(87, 9);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(261, 41);
            this.titre.TabIndex = 35;
            this.titre.Text = "Ajouter Emprente";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(18, 89);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(144, 25);
            this.bunifuCustomLabel1.TabIndex = 34;
            this.bunifuCustomLabel1.Text = "Code Ouvrage :";
            // 
            // code
            // 
            this.code.BorderColor = System.Drawing.Color.SeaGreen;
            this.code.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.code.Location = new System.Drawing.Point(182, 86);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(193, 33);
            this.code.TabIndex = 33;
            this.code.TextChanged += new System.EventHandler(this.code_TextChanged);
            // 
            // nomLable
            // 
            this.nomLable.AutoSize = true;
            this.nomLable.ForeColor = System.Drawing.Color.Red;
            this.nomLable.Location = new System.Drawing.Point(188, 217);
            this.nomLable.Name = "nomLable";
            this.nomLable.Size = new System.Drawing.Size(62, 13);
            this.nomLable.TabIndex = 40;
            this.nomLable.Text = "n\'existe pas";
            this.nomLable.Visible = false;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(18, 184);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(158, 25);
            this.bunifuCustomLabel2.TabIndex = 39;
            this.bunifuCustomLabel2.Text = "Nom Utilisateur :";
            // 
            // nomU
            // 
            this.nomU.BorderColor = System.Drawing.Color.SeaGreen;
            this.nomU.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomU.Location = new System.Drawing.Point(182, 181);
            this.nomU.Name = "nomU";
            this.nomU.Size = new System.Drawing.Size(193, 33);
            this.nomU.TabIndex = 38;
            this.nomU.TextChanged += new System.EventHandler(this.nomU_TextChanged);
            // 
            // AjouterEmprinte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(474, 358);
            this.Controls.Add(this.nomLable);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.nomU);
            this.Controls.Add(this.codeLable);
            this.Controls.Add(this.add);
            this.Controls.Add(this.titre);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.code);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AjouterEmprinte";
            this.Text = "AjouterEmprinte";
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
        private Bunifu.Framework.UI.BunifuCustomLabel nomLable;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox nomU;
    }
}