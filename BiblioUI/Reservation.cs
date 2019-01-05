using System;
using System.Data;
using ServiceFournis;
using System.Windows.Forms;

namespace BiblioUI
{
    public partial class Reservation : UserControl
    {
        public Reservation()
        {
            InitializeComponent();
        }

       
        public void listReservation()
        {
            Emprinte[] emprintes = MainUI.sbo.listReservation();

            DataTable dt = new DataTable();
            for (int i= 1; i<5;i++)
            {
                dt.Columns.Add("" + i + "");
            }

            for(int i =0; i<emprintes.Length;i++ )
            {
                DataRow row = dt.NewRow();
                Emprinte e = emprintes[i];
                row["1"] = e.NumeroEmprinte;
                row["2"] = e.DateReservation;
                row["3"] = e.NomUtilisateurEmprenteur;
                row["4"] = e.CodeOuvrague;

                dt.Rows.Add(row);
            }


            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            GridReservation.DataSource=bs;

        }

        private void valider_Click(object sender, EventArgs e)
        {
            int rowIndex = GridReservation.SelectedCells[0].RowIndex;

            String numSeq = GridReservation.Rows[rowIndex].Cells[0].Value.ToString();
            String codeO = GridReservation.Rows[rowIndex].Cells[3].Value.ToString();
            int num = Convert.ToInt32(numSeq);
            Boolean result= MainUI.sbo.validerReservation(num , codeO);
            if(result)
            {
                listReservation();
            }
            else
            {
                MessageBox.Show("Validation echoé");
            }

        }
    }
}
