using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceFournis;

namespace BiblioUIEmprenteur
{
    public partial class Acceuil : Form
    {
        //public static ServiceClientCompte scc;
        //public static ServiceClientOvrague sco;

        public static ServiceWcf.ServiceClientCompteClient scc;
        public static ServiceWcf.ServiceClientOvragueClient sco;

        public static CompteEtudiant compteEtudiant;
        public static CompteEnseigant CompteEnseigant;

        public static Boolean estEnseignant;

        public Acceuil()
        {
            InitializeComponent();


            try
            {

                /*TcpChannel chl = new TcpChannel();
                ChannelServices.RegisterChannel(chl, false);
                Console.WriteLine("Client: Canal enregistré");
                scc = (ServiceClientCompte)Activator.GetObject(typeof(ServiceClientCompte),
                 "tcp://localhost:1234/FournisseurServiceCompte");
                sco = (ServiceClientOvrague)Activator.GetObject(typeof(ServiceClientOvrague),
                          "tcp://localhost:1234/FournisseurServiceOuvrague");*/


                scc = new ServiceWcf.ServiceClientCompteClient("NetTcpBinding_ServiceClientCompte");
                sco = new ServiceWcf.ServiceClientOvragueClient("NetTcpBinding_ServiceClientOvrague");
                
                

            }
            catch(Exception e)
            {
                Close();
            }
        }

        

        private void Acceuil_Load(object sender, EventArgs e)
        {
            authentifiacationPanel1.BringToFront();
        }

        public void authentification()
        {
            authentifiacationPanel1.BringToFront();
        }

        public void espaceUtilisateur()
        {
            espaceUtilisateur1.BringToFront();
        }

        
    }
}
