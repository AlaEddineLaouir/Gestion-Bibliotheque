using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace Fournisseur_Service
{
    class Serveur
    {
        static void Main(string[] args)
        {
            try
            {
                TcpChannel chnl = new TcpChannel(1234);
                ChannelServices.RegisterChannel(chnl, false);
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(FournisseurServiceCompte),
                "FournisseurServiceCompte", WellKnownObjectMode.Singleton);
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(FournisseurServiceOuvrague),
               "FournisseurServiceOuvrague", WellKnownObjectMode.Singleton);

                Console.WriteLine("Serveur démarré...");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Serveur:Erreur d'initialisation !" + ex.Message);
            }
        }
    }
}
