using System;
using System.Data;
using MySql.Data.MySqlClient;
using ServiceFournis;
namespace Fournisseur_Service
{
    class FournisseurServiceCompte : MarshalByRefObject, ServiceClientCompte, ServiceBibliothecaireCompte
    {
        public Compte[] chercherCompte(string cle)
        {
            throw new NotImplementedException();
        }

        public Compte creeCompte(Compte compte)
        {
            throw new NotImplementedException();
        }

        public bool modifierCompte(string nomUtilisateur, Compte compteNouveau)
        {
            throw new NotImplementedException();
        }

        public Compte seConnecter(string nomUtilisateur, string motPasse)
        {
            throw new NotImplementedException();
        }

        public bool supprimerCompte(Compte c)
        {
            throw new NotImplementedException();
        }

        bool ServiceBibliothecaireCompte.creeCompte(Compte c)
        {
            throw new NotImplementedException();
        }
    }
}
