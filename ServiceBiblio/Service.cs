using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ServiceFournis;

namespace ServiceBiblio
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "CompteService" à la fois dans le code et le fichier de configuration.
    public class Service : ServiceClientCompte , ServiceClientOvrague
    {
        SingltonRemoteObject sro;


        public Service() : base()
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
            return sro.scc.modifierCompteEnseignant(ancien.Nom_utilisteur, compteNouveau);
        }

        public bool modifierCompteEnseignant(string nomUtilisateur, CompteEnseigant compteNouveau)
        {
            return sro.scc.modifierCompteEnseignant(nomUtilisateur, compteNouveau);
        }

        public bool modifierCompteEtudiant(CompteEtudiant ancien, CompteEtudiant compteNouveau)
        {
            return sro.scc.modifierCompteEtudiant(ancien.Nom_utilisteur, compteNouveau);
        }

        public bool modifierCompteEtudiant(string nomUtilisateur, CompteEtudiant compteNouveau)
        {
            return sro.scc.modifierCompteEtudiant(nomUtilisateur, compteNouveau);
        }

        public CompteEnseigant seConnecterEnseignant(string nomUtilisateur, string motPasse)
        {
            return sro.scc.seConnecterEnseignant(nomUtilisateur, motPasse);
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
            }
            catch (Exception e)
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

        // Service Ouvrage

        

        public bool attendreOuvrague(String nomUtilisateur, string codeOuvrague)
        {
            return sro.sco.attendreOuvrague(nomUtilisateur, codeOuvrague);
        }

        public Ouvrague[] chercherOuvrague(string motCle)
        {
            return sro.sco.chercherOuvrague(motCle);
        }

        public Emprinte[] mesEmprintes(String nomUtilisateur)
        {
            return sro.sco.mesEmprintes(nomUtilisateur);
        }

        public Emprinte[] mesReservation(String nomUtilisateur)
        {
            try
            {
                return sro.sco.mesReservation(nomUtilisateur);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message + "----" + e.StackTrace);
                return null;
            }
        }

        public bool reserverOuvrague(String nomUtilisateur, Ouvrague o)
        {
            return sro.sco.reserverOuvrague(nomUtilisateur, o.Code);
        }

        public bool reserverOuvrague(String nomUtilisateur, string codeOuvrague)
        {
            return sro.sco.reserverOuvrague(nomUtilisateur, codeOuvrague);
        }

        public string verifierCodeOuvrague(string Code)
        {
            return sro.sco.verifierCodeOuvrague(Code);
        }

    }
}
