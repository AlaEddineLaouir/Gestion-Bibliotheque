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
    public partial class AuthentifiacationPanel : UserControl
    {
        public AuthentifiacationPanel()
        {
            InitializeComponent();
        }

        private void ConnectEtudiant_Click(object sender, EventArgs e)
        {
            SeConnecterEtudiant sce = new SeConnecterEtudiant();
            sce.ShowDialog(this);
        }

       

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            SeConnecterEnseignant sce = new SeConnecterEnseignant();
            sce.ShowDialog(this);
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            SinscrireEnseignant sie = new SinscrireEnseignant();
            sie.ShowDialog(this);
        }

        private void siEns_Click(object sender, EventArgs e)
        {
            SinscrireEtudiant sie = new SinscrireEtudiant();
            sie.ShowDialog(this);
        }
    }
}
