using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioUIEmprenteur
{
    public partial class EspaceUtilisateur : UserControl
    {
        public EspaceUtilisateur()
        {
            InitializeComponent();
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            Acceuil.CompteEnseigant = null;
            Acceuil.compteEtudiant = null;
            Program.acceuil.authentification();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            if(Acceuil.estEnseignant)
            {
                ModifierProfilEnseignant.ce = Acceuil.CompteEnseigant;
                ModifierProfilEnseignant mpe = new ModifierProfilEnseignant();
                mpe.ShowDialog(this);
            }
            else
            {
                ModifierProfilEtudiant.ce = Acceuil.compteEtudiant;
                ModifierProfilEtudiant mpe = new ModifierProfilEtudiant();
                mpe.ShowDialog(this);
            }

        }

        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {
            ouvrage1.BringToFront();
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            emprente1.listEmprentes();
            emprente1.BringToFront();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            reservation1.listReservation();
            reservation1.BringToFront();
        }
    }
}
