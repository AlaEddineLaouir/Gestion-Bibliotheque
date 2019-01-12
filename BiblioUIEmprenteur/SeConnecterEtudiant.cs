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
    public partial class SeConnecterEtudiant : Form
    {
        public SeConnecterEtudiant()
        {
            InitializeComponent();
        }

        private void nomU_Leave(object sender, EventArgs e)
        {
            String nomUtilisateur = nomU.Text;
            Boolean valide = Acceuil.scc.verifierNomUtilisateur(nomUtilisateur);

            nomLable.Visible = valide;
        }

        private void add_Click(object sender, EventArgs e)
        {
            if( nomU.TextLength>0 && motPasse.TextLength>0 )
            {

                String nmU = nomU.Text;
                String pass = motPasse.Text;

                CompteEtudiant ce = Acceuil.scc.seConnecterEtudaint(nmU, pass);

                if(ce != null)
                {
                    ce.Nom_utilisteur = nmU;
                    ce.Mot_passe = pass;
                    Acceuil.compteEtudiant = ce;
                    Acceuil.estEnseignant = false;
                    Program.acceuil.espaceUtilisateur();
                    Close();
                }else
                {
                    MessageBox.Show(this,"Information de connexion incorrecte","Connexion echoée");
                }
                

            }
            else
            {
                MessageBox.Show("Remplir les champs");
            }
        }
    }
}
