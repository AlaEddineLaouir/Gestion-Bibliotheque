using System;
using ServiceFournis;
using System.Windows.Forms;

namespace BiblioUI
{
    public partial class ProfilEnseignant : Form
    {
        public ProfilEnseignant()
        {
            InitializeComponent();
        }

        private void nomU_Leave(object sender, EventArgs e)
        {
            if(nomU.TextLength>0)
            {
                String nomu = nomU.Text;
                Boolean valide = MainUI.sbc.verifierNomUtilisateur(nomu);
                nomLable.Visible = !valide;
            }

        }

        private void numC_Leave(object sender, EventArgs e)
        {
            if(numC.TextLength>0)
            {
                String matrecule = numC.Text;
                Boolean valide = MainUI.sbc.verifierMatrecule(matrecule);
                matLable.Visible = !valide;
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (nom.TextLength > 0 && prenom.TextLength > 0 && nomU.TextLength > 0 && motPasse.TextLength > 0

                && numC.TextLength > 0 && email.TextLength > 0 && grade.TextLength > 0 )
            {

                CompteEnseigant ce = new CompteEnseigant();
                ce.Nom_utilisteur = nomU.Text;
                ce.Nom = nom.Text;
                ce.Prenom = prenom.Text;
                ce.Grade = grade.Text;
                ce.Email = email.Text;
                ce.Mot_passe = motPasse.Text;
                ce.Matrecule = numC.Text;

                Boolean result = MainUI.sbc.creeCompteEnseignant(ce);
                if (result)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Compte non ajouter");
                }


            }

            else

            {
                MessageBox.Show("Remplir les champs");

            }
        }
    }
}
