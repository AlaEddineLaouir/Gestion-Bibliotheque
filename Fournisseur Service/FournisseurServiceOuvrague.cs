using System;
using ServiceFournis;


namespace Fournisseur_Service
{
    class FournisseurServiceOuvrague : MarshalByRefObject, ServiceBibliothecaireOuvrague, ServiceClientOvrague
    {
        public bool ajouterOuvrague(Ouvrague ouvrague)
        {
            throw new NotImplementedException();
        }

        public bool attendreOuvrague(Compte compte, string codeOuvrague)
        {
            throw new NotImplementedException();
        }

        public Ouvrague[] chercherOuvrague(string motCle)
        {
            throw new NotImplementedException();
        }

        public bool emprinterOuvrague(Compte compte, string codeOuvrague)
        {
            throw new NotImplementedException();
        }

        public Emprinte[] listEmprinte()
        {
            throw new NotImplementedException();
        }

        public Emprinte[] listReservation()
        {
            throw new NotImplementedException();
        }

        public Emprinte[] mesReservation(Compte compte)
        {
            throw new NotImplementedException();
        }

        public bool renderOuvrague(Ouvrague ouvrague)
        {
            throw new NotImplementedException();
        }

        public bool reserverOuvrague(Compte compte, string codeOuvrague)
        {
            throw new NotImplementedException();
        }

        public bool validerReservation(Compte compte, string codeOuvrague)
        {
            throw new NotImplementedException();
        }
    }
}
