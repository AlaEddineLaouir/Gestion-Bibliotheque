using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using ServiceFournis;
using System.Windows.Forms;

namespace BiblioUI
{
    public partial class Emprente : UserControl
    {
        public Emprente()
        {
            InitializeComponent();
        }

        public void listEmprentes()
        {
            Emprinte[] emprintes = MainUI.sbo.listEmprinte();

            DataTable dt = new DataTable();
            for (int i = 1; i < 5; i++)
            {
                dt.Columns.Add("" + i + "");
            }

            for (int i = 0; i < emprintes.Length; i++)
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
            GridEmprente.DataSource = bs;
        }

        private void add_Click(object sender, EventArgs e)
        {
            AjouterEmprinte ae = new AjouterEmprinte();
            ae.ShowDialog(this);
        }

        private void rendre_Click(object sender, EventArgs e)
        {
            int rowIndex = GridEmprente.SelectedCells[0].RowIndex;
            String code = GridEmprente.Rows[rowIndex].Cells[3].Value.ToString();
            int num = Convert.ToInt32(GridEmprente.Rows[rowIndex].Cells[0].Value);
            Boolean reasult = MainUI.sbo.renderOuvrague(code,num);
            if (reasult)
                listEmprentes();
            else
                MessageBox.Show("Opération echoé");
        }
    }
}
