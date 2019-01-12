using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceFournis;

namespace BiblioUIEmprenteur
{
    public partial class SinscrireEtudiant : Form
    {
        public SinscrireEtudiant()
        {
            InitializeComponent();
        }

        private void nomU_Leave(object sender, EventArgs e)
        {
            String nomUtilisateur = nomU.Text;
            Boolean valide = Acceuil.scc.verifierNomUtilisateur(nomUtilisateur);

            nomLable.Visible = !valide;
        }

        private void numC_Leave(object sender, EventArgs e)
        {
            String mat = numC.Text;
            Boolean valide = Acceuil.scc.verifierNumeroCarte(mat);

            matLable.Visible = !valide;
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (nom.TextLength > 0 && prenom.TextLength > 0 && nomU.TextLength > 0 && motPasse.TextLength > 0

                            && numC.TextLength > 0 && email.TextLength > 0 && specialite.TextLength > 0 && niveau.TextLength > 0)
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

                Boolean result = Acceuil.scc.creeCompteEtudiant(ce);
                if (result)
                {
                    Acceuil.compteEtudiant = ce;
                    Acceuil.estEnseignant = false;

                    Program.acceuil.espaceUtilisateur();
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
