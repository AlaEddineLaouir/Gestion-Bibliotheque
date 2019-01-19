using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceFournis;

namespace BiblioUIEmprenteur
{
    public partial class Emprente : UserControl
    {
        public Emprente()
        {
            InitializeComponent();
        }


        public void listEmprentes()
        {
            
            Emprinte[] emprintes;
            if (Acceuil.estEnseignant)
                emprintes = Acceuil.sco.mesEmprintes(Acceuil.CompteEnseigant.Nom_utilisteur);
            else
                emprintes = Acceuil.sco.mesEmprintes(Acceuil.compteEtudiant.Nom_utilisteur);



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

    }
}
