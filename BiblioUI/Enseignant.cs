using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using ServiceFournis;
using System.Windows.Forms;

namespace BiblioUI
{
    public partial class Enseignant : UserControl
    {
        public Enseignant()
        {
            InitializeComponent();
        }

        

        private void add_Click(object sender, EventArgs e)
        {
            ProfilEnseignant pe = new ProfilEnseignant();
            pe.ShowDialog(this);
        }

        private void set_Click(object sender, EventArgs e)
        {
            int rowIndex = GridEnseignant.SelectedCells[0].RowIndex;

            CompteEnseigant ce = new CompteEnseigant();

            ce.Nom_utilisteur = GridEnseignant.Rows[rowIndex].Cells[0].Value.ToString();
            ce.Matrecule= GridEnseignant.Rows[rowIndex].Cells[1].Value.ToString();
            ce.Nom= GridEnseignant.Rows[rowIndex].Cells[2].Value.ToString();
            ce.Prenom= GridEnseignant.Rows[rowIndex].Cells[3].Value.ToString();
            ce.Grade= GridEnseignant.Rows[rowIndex].Cells[4].Value.ToString();
            ce.Email= GridEnseignant.Rows[rowIndex].Cells[5].Value.ToString();

            ModifierEnseignant.ce = ce;
            ModifierEnseignant me = new ModifierEnseignant();
            me.ShowDialog(this);

        }

        private void chercherEnseignant_TextChanged(object sender, EventArgs e)
        {
            if(chercherEnseignant.TextLength>0)
            {
                String cle = chercherEnseignant.Text;
                Compte[] comptes = MainUI.sbc.chercherCompteEnseignant(cle);

                DataTable table = new DataTable();

                // adding columns with names as index
                for (int i = 1; i < 7; i++)
                {
                    table.Columns.Add("" + i + "");
                }

                //filling data table
                for (int i = 0; i < comptes.Length; i++)
                {
                    CompteEnseigant ce = (CompteEnseigant)comptes[i];
                    DataRow row = table.NewRow();

                    row.BeginEdit();
                    row["1"] = ce.Nom_utilisteur;
                    row["2"] = ce.Matrecule;
                    row["3"] = ce.Nom;
                    row["4"] = ce.Prenom;
                    row["5"] = ce.Grade;
                    row["6"] = ce.Email;

                    table.Rows.Add(row);

                }

                BindingSource bs = new BindingSource();
                bs.DataSource = table;

                GridEnseignant.DataSource = bs;


            }
            else
            {
                try
                {
                    GridEnseignant.Rows.Clear();
                }catch(Exception ex) { }
            }
        }
    }
}
