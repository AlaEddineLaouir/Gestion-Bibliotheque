using System;
using ServiceFournis;
using System.Windows.Forms;

namespace BiblioUI
{
    public partial class ProfileEtudiant : Form
    {
        public ProfileEtudiant()
        {
            InitializeComponent();
        }

        private void matrecule_Leave(object sender, EventArgs e)
        {
            String mat = numC.Text;
            Boolean valide = MainUI.sbc.verifierNumeroCarte(mat);

            matLable.Visible = !valide;
        }

        private void nomU_Leave(object sender, EventArgs e)
        {
            String nomUtilisateur = nomU.Text;
            Boolean valide = MainUI.sbc.verifierNomUtilisateur(nomUtilisateur);

            nomLable.Visible = !valide;
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (nom.TextLength > 0 && prenom.TextLength > 0 && nomU.TextLength > 0 && motPasse.TextLength > 0
            
                && numC.TextLength>0 && email.TextLength>0 && specialite.TextLength>0 && niveau.TextLength>0)
            {
                
                CompteEtudiant ce = new CompteEtudiant();
                ce.Nom_utilisteur = nomU.Text;
                ce.Nom = nom.Text;
                ce.Prenom = prenom.Text;
                ce.Specialite = specialite.Text;
                ce.Niveau = niveau.Text;
                ce.NumeroCarte = numC.Text;
                ce.Email = email.Text;
                ce.Mot_passe = motPasse.Text;

                Boolean result = MainUI.sbc.creeCompteEtudiant(ce);
                if(result)
                {
                    this.Close();
                } else
                {
                    MessageBox.Show("Compte non ajouter");
                }


            }

            else

            {
                MessageBox.Show("Remplir les champs");

            }
           
        }

        private void nomU_TextChanged(object sender, EventArgs e)
        {

        }

        private void nomLable_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
