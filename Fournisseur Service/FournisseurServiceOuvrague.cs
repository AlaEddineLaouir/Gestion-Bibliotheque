using System;
using ServiceFournis;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Net.Mail;

namespace Fournisseur_Service
{
    class FournisseurServiceOuvrague : MarshalByRefObject, ServiceBibliothecaireOuvrague, ServiceClientOvrague
    {
        public bool ajouterOuvrague(Ouvrague ouvrague)
        {
            RequeteOuvragueExe roe = new RequeteOuvragueExe();
            return roe.ajouterOuvrague(ouvrague);
        }

        public bool attendreOuvrague(Compte compte, string codeOuvrague)
        {
            RequeteOuvragueExe roe = new RequeteOuvragueExe();
            return roe.attendreOuvrague(compte, codeOuvrague);
        }

        public Ouvrague[] chercherOuvrague(string motCle)
        {
            RequeteOuvragueExe roe = new RequeteOuvragueExe();
            IDataReader reader = roe.chercherOuvrague(motCle);
            List<Ouvrague> listOuvrague = new List<Ouvrague>();
            while(reader.Read())
            {
                Ouvrague ouvrague = new Ouvrague();

                ouvrague.Code = reader.GetString(0);
                ouvrague.Auteur = reader.GetString(3);
                ouvrague.Theme = reader.GetString(2);
                ouvrague.Titre = reader.GetString(4);
                ouvrague.TypeOuvrague = reader.GetString(1);
                ouvrague.Etat = reader.GetString(5);

                listOuvrague.Add(ouvrague);
            }

            return listOuvrague.ToArray();
        }

        public bool dispoOuvrague(string codeOuvrague)
        {
            RequeteOuvragueExe roe =new RequeteOuvragueExe();
            return roe.dispoOuvrague(codeOuvrague);
        }

        public bool emprinterOuvrague(Compte compte, string codeOuvrague)
        {
            RequeteOuvragueExe roe = new RequeteOuvragueExe();
            return roe.emprenterOuvrague(compte, codeOuvrague);
        }

        public Emprinte[] listEmprinte()
        {
            RequeteOuvragueExe roe = new RequeteOuvragueExe();

            IDataReader reader = roe.listEmprinte();
            List<Emprinte> emprintes = new List<Emprinte>();

            while(reader.Read())
            {
                Emprinte emprinte = new Emprinte();

                emprinte.NumeroEmprinte =reader.GetInt64(0).ToString();
                emprinte.DateReservation = (reader.GetDateTime(1)).ToString();
                emprinte.CodeOuvrague = reader.GetString(3);
                emprinte.NomUtilisateurEmprenteur = reader.GetString(2);

                emprintes.Add(emprinte);
            }

            return emprintes.ToArray();
        }

        public Emprinte[] listReservation()
        {
            RequeteOuvragueExe roe = new RequeteOuvragueExe();

            IDataReader reader = roe.listReservation();
            List<Emprinte> emprintes = new List<Emprinte>();

            while (reader.Read())
            {
                Emprinte emprinte = new Emprinte();

                emprinte.NumeroEmprinte = reader.GetInt64(0).ToString();
                //emprinte.DateReservation = reader.GetString(1).ToString();
                emprinte.CodeOuvrague = reader.GetString(3);
                emprinte.NomUtilisateurEmprenteur = reader.GetString(2);

                emprintes.Add(emprinte);
            }

            return emprintes.ToArray();
        }

        public Emprinte[] mesEmprintes(Compte compte)
        {
            RequeteOuvragueExe roe = new RequeteOuvragueExe();

            IDataReader reader = roe.mesEmprente(compte);
            List<Emprinte> emprintes = new List<Emprinte>();

            while (reader.Read())
            {
                Emprinte emprinte = new Emprinte();

                emprinte.NumeroEmprinte = reader.GetString(0);
                emprinte.DateReservation = reader.GetString(1);
                emprinte.CodeOuvrague = reader.GetString(3);
                emprinte.NomUtilisateurEmprenteur = reader.GetString(2);

                emprintes.Add(emprinte);
            }

            return emprintes.ToArray();
        }

        public Emprinte[] mesReservation(Compte compte)
        {
            RequeteOuvragueExe roe = new RequeteOuvragueExe();

            IDataReader reader = roe.mesReservation(compte);
            List<Emprinte> emprintes = new List<Emprinte>();

            while (reader.Read())
            {
                Emprinte emprinte = new Emprinte();

                emprinte.NumeroEmprinte = reader.GetString(0);
                emprinte.DateReservation = reader.GetString(1);
                emprinte.CodeOuvrague = reader.GetString(3);
                emprinte.NomUtilisateurEmprenteur = reader.GetString(2);

                emprintes.Add(emprinte);
            }

            return emprintes.ToArray();
        }

        public bool modifierOuvrague(string codeOuvrague, Ouvrague ouvrague)
        {
            RequeteOuvragueExe roe = new RequeteOuvragueExe();
            return roe.modifierOuvrague(codeOuvrague, ouvrague);
        }

        public bool nonDispoOuvrague(string codeOuvrague)
        {
            RequeteOuvragueExe roe = new RequeteOuvragueExe();
            return roe.nonDispoOuvrague(codeOuvrague);
        }

        public bool renderOuvrague(string code, int numEmprente)
        {
            RequeteOuvragueExe roe = new RequeteOuvragueExe();
            Ouvrague o = new Ouvrague();
            o.Code = code;
            String[] emails = roe.rendreOuvrague(o,numEmprente);

            EmailSender es = new EmailSender();
            es.Emails = emails;
            es.CodeOuvrage = code;
            es.avertire();

            return true;
        }

        public bool reserverOuvrague(Compte compte, string codeOuvrague)
        {
            RequeteOuvragueExe roe = new RequeteOuvragueExe();
            return roe.reserverOuvrague(compte, codeOuvrague);
        }

        public bool validerReservation(int numeroEmprente , String codeOuvrague)
        {
            RequeteOuvragueExe roe = new RequeteOuvragueExe();
            return roe.validerReservation(numeroEmprente,codeOuvrague);
        }

        public String verifierCodeOuvrague(string Code)
        {
            String resulte= new RequeteOuvragueExe().validerCodeOuvrague(Code);
            Console.WriteLine("'"+resulte+"'");
            return resulte; 
        }

        
    }
}
