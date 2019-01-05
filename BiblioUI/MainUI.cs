using System;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using ServiceFournis;
namespace BiblioUI
{
    public partial class MainUI : Form
    {
        public static ServiceBibliothecaireCompte sbc;
        public static ServiceBibliothecaireOuvrague sbo;


        public MainUI()
        {
            InitializeComponent();
            try
            {
                TcpChannel chl = new TcpChannel();
                ChannelServices.RegisterChannel(chl, false);
                Console.WriteLine("Client: Canal enregistré");
                sbc = (ServiceBibliothecaireCompte)Activator.GetObject(typeof(ServiceBibliothecaireCompte),
                 "tcp://localhost:1234/FournisseurServiceCompte");
                sbo = (ServiceBibliothecaireOuvrague)Activator.GetObject(typeof(ServiceBibliothecaireOuvrague),
                    "tcp://localhost:1234/FournisseurServiceOuvrague");
            }
            catch(Exception e )
            {
                MessageBox.Show("Une error pendant la recupiration des references ");
                this.Close();
            }
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
            reservation1.listReservation();
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            emprente1.BringToFront();
            emprente1.listEmprentes();
        }
    }
}
