namespace BiblioUI
{
    partial class ajouterOuvrague
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ajouterOuvrague));
            this.codeLable = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.titre = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.theme = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.auteur = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.type = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.titreO = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
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
            this.codeLable.Location = new System.Drawing.Point(210, 115);
            this.codeLable.Name = "codeLable";
            this.codeLable.Size = new System.Drawing.Size(59, 13);
            this.codeLable.TabIndex = 32;
            this.codeLable.Text = "deja utiliser";
            this.codeLable.Visible = false;
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.Location = new System.Drawing.Point(170, -2);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(245, 41);
            this.titre.TabIndex = 30;
            this.titre.Text = "Ajouter Ouvrage";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(40, 208);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(80, 25);
            this.bunifuCustomLabel7.TabIndex = 29;
            this.bunifuCustomLabel7.Text = "Theme :";
            // 
            // theme
            // 
            this.theme.BorderColor = System.Drawing.Color.SeaGreen;
            this.theme.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theme.Location = new System.Drawing.Point(204, 205);
            this.theme.Name = "theme";
            this.theme.Size = new System.Drawing.Size(193, 33);
            this.theme.TabIndex = 28;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(40, 269);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(81, 25);
            this.bunifuCustomLabel5.TabIndex = 25;
            this.bunifuCustomLabel5.Text = "Auteur :";
            // 
            // auteur
            // 
            this.auteur.BorderColor = System.Drawing.Color.SeaGreen;
            this.auteur.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auteur.Location = new System.Drawing.Point(204, 263);
            this.auteur.Name = "auteur";
            this.auteur.Size = new System.Drawing.Size(193, 33);
            this.auteur.TabIndex = 24;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(40, 153);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(140, 25);
            this.bunifuCustomLabel4.TabIndex = 23;
            this.bunifuCustomLabel4.Text = "Type Ouvrage :";
            // 
            // type
            // 
            this.type.AutoCompleteCustomSource.AddRange(new string[] {
            "Livre",
            "These",
            "Memoire"});
            this.type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.type.BorderColor = System.Drawing.Color.SeaGreen;
            this.type.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.Location = new System.Drawing.Point(204, 150);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(193, 33);
            this.type.TabIndex = 22;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(40, 329);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(61, 25);
            this.bunifuCustomLabel3.TabIndex = 21;
            this.bunifuCustomLabel3.Text = "Titre :";
            // 
            // titreO
            // 
            this.titreO.BorderColor = System.Drawing.Color.SeaGreen;
            this.titreO.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titreO.Location = new System.Drawing.Point(204, 326);
            this.titreO.Name = "titreO";
            this.titreO.Size = new System.Drawing.Size(193, 33);
            this.titreO.TabIndex = 20;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(40, 82);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(66, 25);
            this.bunifuCustomLabel1.TabIndex = 19;
            this.bunifuCustomLabel1.Text = "Code :";
            // 
            // code
            // 
            this.code.BorderColor = System.Drawing.Color.SeaGreen;
            this.code.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.code.Location = new System.Drawing.Point(204, 79);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(193, 33);
            this.code.TabIndex = 18;
            this.code.TextChanged += new System.EventHandler(this.code_TextChanged);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.White;
            this.add.Image = global::BiblioUI.Properties.Resources.add;
            this.add.ImageActive = null;
            this.add.Location = new System.Drawing.Point(454, 367);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(71, 71);
            this.add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.add.TabIndex = 31;
            this.add.TabStop = false;
            this.add.Zoom = 10;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // ajouterOuvrague
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(576, 450);
            this.Controls.Add(this.codeLable);
            this.Controls.Add(this.add);
            this.Controls.Add(this.titre);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.theme);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.auteur);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.type);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.titreO);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.code);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ajouterOuvrague";
            this.Text = "ajouterOuvrague";
            ((System.ComponentModel.ISupportInitialize)(this.add)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel codeLable;
        private Bunifu.Framework.UI.BunifuImageButton add;
        private Bunifu.Framework.UI.BunifuCustomLabel titre;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox theme;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox auteur;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox type;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox titreO;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox code;
    }
}