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
    public partial class SinscrireEnseignant : Form
    {
        public SinscrireEnseignant()
        {
            InitializeComponent();
        }

        private void nomU_Leave(object sender, EventArgs e)
        {
            if (nomU.TextLength > 0)
            {
                String nomu = nomU.Text;
                Boolean valide = Acceuil.scc.verifierNomUtilisateur(nomu);
                nomLable.Visible = !valide;
            }
        }

        private void numC_Leave(object sender, EventArgs e)
        {
            if (numC.TextLength > 0)
            {
                String matrecule = numC.Text;
                Boolean valide = Acceuil.scc.verifierMatrecule(matrecule);
                matLable.Visible = !valide;
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (nom.TextLength > 0 && prenom.TextLength > 0 && nomU.TextLength > 0 && motPasse.TextLength > 0

                && numC.TextLength > 0 && email.TextLength > 0 && grade.TextLength > 0)
            {

                CompteEnseigant ce = new CompteEnseigant();
                ce.Nom_utilisteur = nomU.Text;
                ce.Nom = nom.Text;
                ce.Prenom = prenom.Text;
                ce.Grade = grade.Text;
                ce.Email = email.Text;
                ce.Mot_passe = motPasse.Text;
                ce.Matrecule = numC.Text;

                Boolean result = Acceuil.scc.creeCompteEnseignant(ce);
                if (result)
                {
                    Acceuil.CompteEnseigant = ce;
                    Acceuil.estEnseignant = true;

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
