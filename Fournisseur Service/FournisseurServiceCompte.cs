using System;
using System.Data;
using MySql.Data.MySqlClient;
using ServiceFournis;
using System.Collections;
using System.Collections.Generic;

namespace Fournisseur_Service
{
    class FournisseurServiceCompte : MarshalByRefObject, ServiceClientCompte, ServiceBibliothecaireCompte
    {
        public Compte[] chercherCompteEnseignant(string cle)
        {
            RequeteCompteExe rce = new RequeteCompteExe();
            IDataReader readre = rce.cherhcerEnseignant(cle);
            List<CompteEnseigant> enseigants = new List<CompteEnseigant>();

            while(readre.Read())
            {
                CompteEnseigant enseigant = new CompteEnseigant();

                enseigant.Nom_utilisteur = readre.GetString(0);
                enseigant.Grade = readre.GetString(4);
                enseigant.Matrecule = readre.GetString(1);
                enseigant.Email = readre.GetString(5);
                enseigant.Nom = readre.GetString(2);
                enseigant.Prenom = readre.GetString(3);

                enseigants.Add(enseigant);
            }

            return enseigants.ToArray();

        }

        public Compte[] chercherCompteEtudiant(string cle)
        {
            Console.WriteLine("recherche d'un  etudiant avec  : " + cle);

            RequeteCompteExe rce = new RequeteCompteExe();
            IDataReader readre = rce.chercherEtudiant(cle);
            List<CompteEtudiant> etudiants = new List<CompteEtudiant>();
            
            while (readre.Read())
            {
                CompteEtudiant etudiant = new CompteEtudiant();

                etudiant.Nom_utilisteur = readre.GetString(0);
                etudiant.Specialite = readre.GetString(4);
                etudiant.NumeroCarte = readre.GetString(1);
                etudiant.Email = readre.GetString(6);
                etudiant.Nom = readre.GetString(2);
                etudiant.Prenom = readre.GetString(3);
                etudiant.Niveau = readre.GetString(5);

                etudiants.Add(etudiant);
            }

            return etudiants.ToArray();
        }

        public bool creeCompteEnseignant(CompteEnseigant c)
        {
            RequeteCompteExe rce = new RequeteCompteExe();
            return rce.creeCompteEnseignant(c);
        }

        public bool creeCompteEtudiant(CompteEtudiant c)
        {
            RequeteCompteExe rce = new RequeteCompteExe();
            return rce.creeCompteEtudiant(c);
        }

        public bool modifierCompteEnseignant(string nomUtilisateur, CompteEnseigant compteNouveau)
        {
            RequeteCompteExe rce = new RequeteCompteExe();
            return rce.modiferCompteEnseignant(nomUtilisateur, compteNouveau);
        }

        public bool modifierCompteEtudiant(string nomUtilisateur, CompteEtudiant compteNouveau)
        {
            RequeteCompteExe rce = new RequeteCompteExe();
            return rce.modifierCompteEtudiant(nomUtilisateur, compteNouveau);
        }

        public CompteEnseigant seConnecterEnseignant(string nomUtilisateur, string motPasse)
        {
            RequeteCompteExe rce = new RequeteCompteExe();
            return rce.seConnecterEnseignant(nomUtilisateur, motPasse);
        }

        public CompteEtudiant seConnecterEtudaint(string nomUtilisateur, string motPasse)
        {
            RequeteCompteExe rce = new RequeteCompteExe();
            CompteEtudiant ce =rce.seConnectEtudiant(nomUtilisateur, motPasse);
            Console.WriteLine("Connexion : "+ce.Nom_utilisteur);
            return ce;
        }

        
        public Boolean verifierMatrecule(string matrecule)
        {
            RequeteCompteExe rce = new RequeteCompteExe();
            return rce.verifierMatrecule(matrecule);
        }

        public Boolean verifierNomUtilisateur(string nomUtilisateur)
        {
            RequeteCompteExe rce = new RequeteCompteExe();
            return rce.verifierNomUtilisateur(nomUtilisateur);
        }

        public Boolean verifierNumeroCarte(string numeroCarte)
        {
            RequeteCompteExe rce = new RequeteCompteExe();
            return rce.verifierNumeroCarte(numeroCarte);
        }
    }
}
