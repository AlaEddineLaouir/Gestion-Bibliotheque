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
    public partial class ModifierProfilEtudiant : Form
    {
        public static CompteEtudiant ce;

        public ModifierProfilEtudiant()
        {
            InitializeComponent();

            nomU.Text = ce.Nom_utilisteur;
            nom.Text = ce.Nom;
            prenom.Text = ce.Prenom;
            specialite.Text = ce.Specialite;
            niveau.Text = ce.Niveau;
            numC.Text = ce.NumeroCarte;
            email.Text = ce.Email;
            motPasse.Text = ce.Mot_passe;
        }

        private void nomU_Leave(object sender, EventArgs e)
        {
            if (!nomU.Text.Equals(ce.Nom_utilisteur))
            {
                String nomUtilisateur = nomU.Text;
                Boolean valide = Acceuil.scc.verifierNomUtilisateur(nomUtilisateur);

                nomLable.Visible = !valide;
            }
        }

        private void numC_Leave(object sender, EventArgs e)
        {
            if (!numC.Text.Equals(ce.NumeroCarte))
            {
                String mat = numC.Text;
                Boolean valide = Acceuil.scc.verifierNumeroCarte(mat);

                matLable.Visible = !valide;
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (nom.TextLength > 0 && prenom.TextLength > 0 && nomU.TextLength > 0 && motPasse.TextLength>0

                            && numC.TextLength > 0 && email.TextLength > 0 && specialite.TextLength > 0 && niveau.TextLength > 0)
            {

                CompteEtudiant c = new CompteEtudiant();
                c.Nom_utilisteur = nomU.Text;
                c.Nom = nom.Text;
                c.Prenom = prenom.Text;
                c.Specialite = specialite.Text;
                c.Niveau = niveau.Text;
                c.NumeroCarte = numC.Text;
                c.Email = email.Text;
                c.Mot_passe = motPasse.Text;


                Boolean result = Acceuil.scc.modifierCompteEtudiant(ce.Nom_utilisteur, c);
                if (result)
                {
                    Acceuil.compteEtudiant = c;
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
