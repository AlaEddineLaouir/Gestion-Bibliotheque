using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioUI
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void MainUI_Load(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            emprenteur1.BringToFront();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            ouvrage1.BringToFront();
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            reservation1.BringToFront();
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            emprente1.BringToFront();
        }
    }
}
