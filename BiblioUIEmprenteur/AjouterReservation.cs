using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioUIEmprenteur
{
    public partial class AjouterReservation : Form
    {

        private bool reserver=false;

        public AjouterReservation()
        {
            InitializeComponent();
        }

        private void code_TextChanged(object sender, EventArgs e)
        {
            if (code.TextLength > 0)
            {
                String cd = code.Text;
                String result = Acceuil.sco.verifierCodeOuvrague(cd);
                codeLable.Visible = true;

                if (result.Equals("Emprenter"))
                {
                    reserver = false;
                    codeLable.Text = result;
                }
                else
                {
                    reserver = true;

                    if (result.Length > 2)
                        codeLable.Text = result;
                    else
                        codeLable.Text = "n'exsite pas";
                }
            }
        }

        

        private void add_Click(object sender, EventArgs e)
        {
            String nomU = "";
            String codeO = code.Text; 
            if (Acceuil.estEnseignant)
                nomU = Acceuil.CompteEnseigant.Nom_utilisteur;
            else
                nomU = Acceuil.compteEtudiant.Nom_utilisteur;

            if(reserver)
            {
                bool resultat = Acceuil.sco.reserverOuvrague(nomU, codeO);
                if (resultat)
                    MessageBox.Show("Votre reservation a ete bien effectue ");
                else
                    MessageBox.Show("Votre reservation a ete échoé ");
            }else
            {
                bool resultat = Acceuil.sco.attendreOuvrague(nomU, codeO);
                if (resultat)
                    MessageBox.Show(" Vous etez dans la liste d'attente pour ce ouvrage ");
                else
                    MessageBox.Show("Votre demande  n'a pas ete effectue ");
            }
        }
    }
}
