using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ServiceFournis;

namespace BiblioWcfService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "OuvrageService" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez OuvrageService.svc ou OuvrageService.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class OuvrageService : IOuvrageService
    {
        SingltonRemoteObject sro;

        public OuvrageService():base()
        {
            sro = SingltonRemoteObject.createInstance();
        }

        public bool attendreOuvrague(Compte compte, Ouvrague o)
        {
            return sro.sco.attendreOuvrague(compte, o.Code);
        }

        public Ouvrague[] chercherOuvrague(string motCle)
        {
            return sro.sco.chercherOuvrague(motCle);
        }

        public Emprinte[] mesEmprintes(Compte compte)
        {
            return sro.sco.mesEmprintes(compte);
        }

        public Emprinte[] mesReservation(Compte compte)
        {
            return sro.sco.mesReservation(compte);
        }

        public bool reserverOuvrague(Compte compte, Ouvrague o)
        {
            return sro.sco.reserverOuvrague(compte, o.Code);
        }

        public string verifierCodeOuvrague(string Code)
        {
            return sro.sco.verifierCodeOuvrague(Code);
        }
    }
}
