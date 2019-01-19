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

namespace BiblioUI
{
    public partial class AjouterEmprinte : Form
    {
        public AjouterEmprinte()
        {
            InitializeComponent();
        }

        private void code_TextChanged(object sender, EventArgs e)
        {
            if (code.TextLength > 0)
            {
                String cd = code.Text;
                String result = MainUI.sbo.verifierCodeOuvrague(cd);
                codeLable.Visible = true;
                if (result.Length > 2)
                    codeLable.Text = result;
                else
                    codeLable.Text = "n'exsite pas";


            }
        }

        private void nomU_TextChanged(object sender, EventArgs e)
        {
            String nomUtilisateur = nomU.Text;
            Boolean valide = MainUI.sbc.verifierNomUtilisateur(nomUtilisateur);

            nomLable.Visible = valide;
        }

        private void add_Click(object sender, EventArgs e)
        {
            Compte c = new Compte();
            c.Nom_utilisteur = nomU.Text;
            String codeO = code.Text;
            Boolean result = MainUI.sbo.emprinterOuvrague(c.Nom_utilisteur,codeO);
            if(result)
            {
                this.Close();
            }else
            {
                MessageBox.Show("Operation echoé");
            }
        }
    }
}
