using System;
using ServiceFournis;
using System.Windows.Forms;

namespace BiblioUI
{
    
    public partial class ModifierEnseignant : Form
    {
        public static CompteEnseigant ce;
        public ModifierEnseignant()
        {
            InitializeComponent();

            nomU.Text = ce.Nom_utilisteur;
            nom.Text = ce.Nom;
            prenom.Text = ce.Prenom;
            mat.Text = ce.Matrecule;
            grade.Text = ce.Grade;
            email.Text = ce.Email;

        }

        private void nomU_Leave(object sender, EventArgs e)
        {
            if (!nomU.Text.Equals(ce.Nom_utilisteur))
            {
                String nomUtilisateur = nomU.Text;
                Boolean valide = MainUI.sbc.verifierNomUtilisateur(nomUtilisateur);

                nomLable.Visible = !valide;
            }else
            {
                nomLable.Visible = false;
            }
        }

        private void mat_Leave(object sender, EventArgs e)
        {
            if( ! mat.Text.Equals(ce.Matrecule))
            {
                String mate = mat.Text;
                Boolean valide = MainUI.sbc.verifierMatrecule(mate);

                matLable.Visible = !valide;
            }
            else
            {
                matLable.Visible = false;
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (nom.TextLength > 0 && prenom.TextLength > 0 && nomU.TextLength > 0

               && mat.TextLength > 0 && email.TextLength > 0 && grade.TextLength > 0 )
            {

                CompteEnseigant c = new CompteEnseigant();
                c.Nom_utilisteur = nomU.Text;
                c.Nom = nom.Text;
                c.Prenom = prenom.Text;
                c.Grade = grade.Text;
                c.Matrecule = mat.Text;
                c.Email = email.Text;


                Boolean result = MainUI.sbc.modifierCompteEnseignant(ce.Nom_utilisteur, c);
                if (result)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Compte non modifier");
                }


            }

            else

            {
                MessageBox.Show("Remplir les champs");

            }
        }
    }
}
