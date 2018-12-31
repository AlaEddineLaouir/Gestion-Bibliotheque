using System;
using System.Data;
using MySql.Data.MySqlClient;
using ServiceFournis;
using System.Collections.Generic;

namespace Fournisseur_Service
{
    class FournisseurServiceCompte : MarshalByRefObject, ServiceClientCompte, ServiceBibliothecaireCompte
    {
        public Compte[] chercherCompteEnseignant(string cle)
        {
            RequeteCompteExe rce = new RequeteCompteExe();
            MySqlDataReader readre = rce.cherhcerEnseignant(cle);
            List<CompteEnseigant> enseigants = new List<CompteEnseigant>();

            while(readre.Read())
            {
                CompteEnseigant enseigant = new CompteEnseigant();

                enseigant.Nom_utilisteur = readre.GetString("nomUtilisateur");
                enseigant.Grade = readre.GetString("grade");
                enseigant.Matrecule = readre.GetString("matricule");
                enseigant.Email = readre.GetString("email");
                enseigant.Nom = readre.GetString("nom");
                enseigant.Prenom = readre.GetString("prenom");

                enseigants.Add(enseigant);
            }

            return enseigants.ToArray();

        }

        public Compte[] chercherCompteEtudiant(string cle)
        {
            RequeteCompteExe rce = new RequeteCompteExe();
            MySqlDataReader readre = rce.chercherEtudiant(cle);
            List<CompteEtudiant> etudiants = new List<CompteEtudiant>();

            while (readre.Read())
            {
                CompteEtudiant etudiant = new CompteEtudiant();

                etudiant.Nom_utilisteur = readre.GetString("nomUtilisateur");
                etudiant.Specialite = readre.GetString("specialite");
                etudiant.NumeroCarte = readre.GetString("numCarte");
                etudiant.Email = readre.GetString("email");
                etudiant.Nom = readre.GetString("nom");
                etudiant.Prenom = readre.GetString("prenom");
                etudiant.Niveau = readre.GetString("niveua");

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
            return (CompteEnseigant)rce.seConnecterEnseignant(nomUtilisateur, motPasse);
        }

        public CompteEtudiant seConnecterEtudaint(string nomUtilisateur, string motPasse)
        {
            RequeteCompteExe rce = new RequeteCompteExe();
            return (CompteEtudiant)rce.seConnectEtudiant(nomUtilisateur, motPasse);
        }

        
        public bool verifierMatrecule(string matrecule)
        {
            RequeteCompteExe rce = new RequeteCompteExe();
            return rce.verifierMatrecule(matrecule);
        }

        public bool verifierNomUtilisateur(string nomUtilisateur)
        {
            RequeteCompteExe rce = new RequeteCompteExe();
            return rce.verifierNomUtilisateur(nomUtilisateur);
        }

        public bool verifierNumeroCarte(string numeroCarte)
        {
            RequeteCompteExe rce = new RequeteCompteExe();
            return rce.verifierNumeroCarte(numeroCarte);
        }
    }
}
