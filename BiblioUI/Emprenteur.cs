using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioUI
{
    public partial class Emprenteur : UserControl
    {
        public Emprenteur()
        {
            InitializeComponent();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            etudiant1.BringToFront();
            Slide.Left = ((Bunifu.Framework.UI.BunifuTileButton)sender).Left-27;
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            enseignant1.BringToFront();
            Slide.Left = ((Bunifu.Framework.UI.BunifuTileButton)sender).Left-27;
        }
    }
}
