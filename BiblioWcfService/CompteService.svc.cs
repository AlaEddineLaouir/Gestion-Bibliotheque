using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ServiceFournis;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;


namespace BiblioWcfService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "CompteService" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez CompteService.svc ou CompteService.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class CompteService : ICompteService
    {

        SingltonRemoteObject sro;


        public CompteService() : base()
        {
            
            sro = SingltonRemoteObject.createInstance();
        }  

        public bool creeCompteEnseignant(CompteEnseigant c)
        {
            return sro.scc.creeCompteEnseignant(c);
        }

        public bool creeCompteEtudiant(CompteEtudiant c)
        {
            return sro.scc.creeCompteEtudiant(c);
        }

       

        public bool modifierCompteEnseignant(CompteEnseigant ancien, CompteEnseigant compteNouveau)
        {
            return sro.scc.modifierCompteEnseignant(ancien.Nom_utilisteur,compteNouveau);
        }

       
        public bool modifierCompteEtudiant(CompteEtudiant ancien, CompteEtudiant compteNouveau)
        {
            return sro.scc.modifierCompteEtudiant(ancien.Nom_utilisteur, compteNouveau);
        }

        public CompteEnseigant seConnecterEnseignant(string nomUtilisateur, string motPasse)
        {
            return sro.scc.seConnecterEnseignant(nomUtilisateur,motPasse);
        }

        public CompteEtudiant seConnecterEtudaint(string nomUtilisateur, string motPasse)
        {
            try
            {
                CompteEtudiant ce = sro.scc.seConnecterEtudaint(nomUtilisateur, motPasse);
                if (ce == null)
                    Console.WriteLine("L ghalta mech hna ");
                else
                    Console.WriteLine("nom : " + ce.Nom + " !email :" + ce.Email);
                return ce;
            }catch(Exception e)
            {
                return null;
            }
        }

        public bool verifierMatrecule(string matrecule)
        {
            return sro.scc.verifierMatrecule(matrecule);
        }

        public bool verifierNomUtilisateur(string nomUtilisateur)
        {
                return sro.scc.verifierNomUtilisateur(nomUtilisateur);
        }

        public bool verifierNumeroCarte(string numeroCarte)
        {
            return sro.scc.verifierNumeroCarte(numeroCarte);
        }
    }
}
