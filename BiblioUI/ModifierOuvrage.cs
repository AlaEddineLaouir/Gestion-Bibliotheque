using System;
using ServiceFournis;
using System.Windows.Forms;

namespace BiblioUI
{
    public partial class ModifierOuvrage : Form
    {
        public static Ouvrague o; 
        public ModifierOuvrage()
        {
            InitializeComponent();

            code.Text = o.Code;
            theme.Text = o.Theme;
            type.Text = o.TypeOuvrague;
            titreO.Text = o.Titre;
            auteur.Text = o.Auteur;
        }

        private void code_TextChanged(object sender, EventArgs e)
        {
            if (code.TextLength > 0)
            {
                if (code.Text.Equals(o.Code))
                {
                    codeLable.Visible = true;
                    codeLable.Text = "";
                }
                else
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

        private void add_Click(object sender, EventArgs e)
        {
            if (code.TextLength > 0 && type.TextLength > 0 && theme.TextLength > 0 && auteur.TextLength > 0 && titreO.TextLength > 0)
            {
                Ouvrague o1 = new Ouvrague();

                o1.Code = code.Text;
                o1.Theme = theme.Text;
                o1.Titre = titreO.Text;
                o1.Auteur = auteur.Text;
                o1.TypeOuvrague = type.Text;

                Boolean result = MainUI.sbo.modifierOuvrague(o.Code,o1);
                if (result)
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
    }
}
