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
    public partial class Ouvrage : UserControl
    {
        public Ouvrage()
        {
            InitializeComponent();
        }

        private void cherhcerOuvrage_TextChanged(object sender, EventArgs e)
        {
            if (cherhcerOuvrage.TextLength > 0)
            {
                String cle = cherhcerOuvrage.Text;

                Ouvrague[] ouvragues = Acceuil.sco.chercherOuvrague(cle);

                DataTable dt = new DataTable();

                for (int i = 1; i < 7; i++)
                {
                    dt.Columns.Add("" + i + "");
                }

                for (int i = 0; i < ouvragues.Length; i++)
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
    }
}
