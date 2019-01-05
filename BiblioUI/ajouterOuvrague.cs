using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using ServiceFournis;
using System.Windows.Forms;

namespace BiblioUI
{
    public partial class ajouterOuvrague : Form
    {
        public ajouterOuvrague()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if( code.TextLength>0 && type.TextLength>0 && theme.TextLength > 0 && auteur.TextLength > 0 && titreO.TextLength > 0)
            {
                Ouvrague o = new Ouvrague();

                o.Code = code.Text;
                o.Theme = theme.Text;
                o.Titre = titreO.Text;
                o.Auteur = auteur.Text;
                o.TypeOuvrague = type.Text;

                Boolean result = MainUI.sbo.ajouterOuvrague(o);
                if(result)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Operation echoé");
                }
            }
            else
            {
                MessageBox.Show("Champs non Remplit");
            }
        }

        private void code_TextChanged(object sender, EventArgs e)
        {
            if(code.TextLength>0)
            {
                String cd = code.Text;
                String result = MainUI.sbo.verifierCodeOuvrague(cd);
                codeLable.Visible = true;
                if (result.Length>2)
                    codeLable.Text = "existe deja";
                else
                    codeLable.Text = "";
            }
        }

        
    }
}
