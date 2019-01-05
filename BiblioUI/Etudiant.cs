using System;
using ServiceFournis;
using System.Windows.Forms;
using System.Data;


namespace BiblioUI
{
    public partial class Etudiant : UserControl
    {
        
        public Etudiant()
        {
            InitializeComponent();
          
         }

        private void chercherEtudiant_TextChanged(object sender, EventArgs e)
        {
            if( chercherEtudiant.TextLength > 0)
            {
                String cle = chercherEtudiant.Text;
                Compte [] comptes= MainUI.sbc.chercherCompteEtudiant(cle);

                DataTable table = new DataTable();

                // adding columns with names as index
                for(int i = 1; i<8;i++)
                {
                    table.Columns.Add("" + i + "");
                }

                //filling data table
                for(int i =0; i < comptes.Length;i++)
                {
                    CompteEtudiant ce = (CompteEtudiant)comptes[i];
                    DataRow row = table.NewRow();

                    row.BeginEdit();
                    row["1"] = ce.Nom_utilisteur;
                    row["2"] = ce.NumeroCarte;
                    row["3"] = ce.Nom;
                    row["4"] = ce.Prenom;
                    row["5"] = ce.Specialite;
                    row["6"] = ce.Niveau;
                    row["7"] = ce.Email;

                    table.Rows.Add(row);
                    
                }

                BindingSource bs =new BindingSource();
                bs.DataSource = table;
                
                GridEtudiant.DataSource = bs;
            }
            else
            {
                try { GridEtudiant.Rows.Clear(); }catch(Exception ex) { }
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            ProfileEtudiant pe = new ProfileEtudiant();
            pe.ShowDialog(this);
            
        }

        private void set_Click(object sender, EventArgs e)
        {
            int rowIndex=GridEtudiant.SelectedCells[0].RowIndex;


            CompteEtudiant ce = new CompteEtudiant();

            ce.Nom_utilisteur = GridEtudiant.Rows[rowIndex].Cells[0].Value.ToString();
            ce.Nom = GridEtudiant.Rows[rowIndex].Cells[2].Value.ToString();
            ce.Prenom = GridEtudiant.Rows[rowIndex].Cells[3].Value.ToString();
            ce.Specialite = GridEtudiant.Rows[rowIndex].Cells[4].Value.ToString();
            ce.Niveau = GridEtudiant.Rows[rowIndex].Cells[5].Value.ToString();
            ce.NumeroCarte = GridEtudiant.Rows[rowIndex].Cells[1].Value.ToString();
            ce.Email = GridEtudiant.Rows[rowIndex].Cells[6].Value.ToString();



            ModifierEtudiant.ce = ce;
            ModifierEtudiant me = new ModifierEtudiant();
            me.ShowDialog(this);

        }
    }
}
