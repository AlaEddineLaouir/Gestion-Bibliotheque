using System;
using System.Data;
using ServiceFournis;
using System.Windows.Forms;

namespace BiblioUI
{
    public partial class Ouvrage : UserControl
    {
        public Ouvrage()
        {
            InitializeComponent();
        }

        private void bunifuCustomTextbox1_TextChanged(object sender, EventArgs e)
        {
            if(cherhcerOuvrage.TextLength>0)
            {
                String cle = cherhcerOuvrage.Text;

                Ouvrague[] ouvragues = MainUI.sbo.chercherOuvrague(cle);

                DataTable dt = new DataTable();

                for(int i = 1; i<7;i++)
                {
                    dt.Columns.Add("" + i + "");
                }

                for(int i =0; i< ouvragues.Length; i++)
                {
                    DataRow row = dt.NewRow();
                    Ouvrague o = ouvragues[i];

                    row["1"] = o.Code;
                    row["2"] = o.TypeOuvrague;
                    row["3"] = o.Theme;
                    row["4"] = o.Auteur;
                    row["5"] = o.Titre;
                    row["6"] = o.Etat;

                    dt.Rows.Add(row);
                }

                BindingSource bd = new BindingSource();
                bd.DataSource = dt;
                GridOuvrage.DataSource = bd;
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            ajouterOuvrague ao = new ajouterOuvrague();
            ao.ShowDialog(this);
        }

        private void set_Click(object sender, EventArgs e)
        {
            Ouvrague o=new Ouvrague();

            int rowIndex = GridOuvrage.SelectedCells[0].RowIndex;

            o.Code = GridOuvrage.Rows[rowIndex].Cells[0].Value.ToString();
            o.TypeOuvrague= GridOuvrage.Rows[rowIndex].Cells[1].Value.ToString();
            o.Theme= GridOuvrage.Rows[rowIndex].Cells[2].Value.ToString();
            o.Auteur= GridOuvrage.Rows[rowIndex].Cells[4].Value.ToString();
            o.Titre= GridOuvrage.Rows[rowIndex].Cells[3].Value.ToString();

            ModifierOuvrage.o = o;
            ModifierOuvrage mo = new ModifierOuvrage();
            mo.ShowDialog(this);
        }

        private void nonDispo_Click(object sender, EventArgs e)
        {
            int rowIndex = GridOuvrage.SelectedCells[0].RowIndex;
            String code = GridOuvrage.Rows[rowIndex].Cells[0].Value.ToString();

            Boolean result = MainUI.sbo.nonDispoOuvrague(code);

            if(result)
            {
                bunifuCustomTextbox1_TextChanged(sender,e);
            }
            else
            {
                MessageBox.Show("Modification echoé");

            }
        }

        private void dispo_Click(object sender, EventArgs e)
        {
            int rowIndex = GridOuvrage.SelectedCells[0].RowIndex;
            String code = GridOuvrage.Rows[rowIndex].Cells[0].Value.ToString();

            Boolean result = MainUI.sbo.dispoOuvrague(code);

            if (result)
            {
                bunifuCustomTextbox1_TextChanged(sender, e);
            }
            else
            {
                MessageBox.Show("Modification echoé");

            }
        }
    }
}
