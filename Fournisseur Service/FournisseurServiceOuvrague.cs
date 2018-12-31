using System;
using ServiceFournis;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

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
            MySqlDataReader reader = roe.chercherOuvrague(motCle);
            List<Ouvrague> listOuvrague = new List<Ouvrague>();
            while(reader.Read())
            {
                Ouvrague ouvrague = new Ouvrague();

                ouvrague.Code = reader.GetString("code");
                ouvrague.Auteur = reader.GetString("auteur");
                ouvrague.Theme = reader.GetString("theme");
                ouvrague.Titre = reader.GetString("titre");
                ouvrague.TypeOuvrague = reader.GetString("typeOuvrague");
                ouvrague.Disponible = reader.GetBoolean("disponible");

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

            MySqlDataReader reader = roe.listEmprinte();
            List<Emprinte> emprintes = new List<Emprinte>();

            while(reader.Read())
            {
                Emprinte emprinte = new Emprinte();

                emprinte.DateReservation = reader.GetString("dateReservation");
                emprinte.CodeOuvrague = reader.GetString("codeOuvrague");
                emprinte.NomUtilisateurEmprenteur = reader.GetString("nomUtilisateur_emprenteur");

                emprintes.Add(emprinte);
            }

            return emprintes.ToArray();
        }

        public Emprinte[] listReservation()
        {
            RequeteOuvragueExe roe = new RequeteOuvragueExe();

            MySqlDataReader reader = roe.listReservation();
            List<Emprinte> emprintes = new List<Emprinte>();

            while (reader.Read())
            {
                Emprinte emprinte = new Emprinte();

                emprinte.NumeroEmprinte = reader.GetInt32("numSeq");
                emprinte.DateReservation = reader.GetString("dateReservation");
                emprinte.CodeOuvrague = reader.GetString("codeOuvrague");
                emprinte.NomUtilisateurEmprenteur = reader.GetString("nomUtilisateur_emprenteur");

                emprintes.Add(emprinte);
            }

            return emprintes.ToArray();
        }

        public Emprinte[] mesEmprintes(Compte compte)
        {
            RequeteOuvragueExe roe = new RequeteOuvragueExe();

            MySqlDataReader reader = roe.mesEmprente(compte);
            List<Emprinte> emprintes = new List<Emprinte>();

            while (reader.Read())
            {
                Emprinte emprinte = new Emprinte();

                emprinte.DateReservation = reader.GetString("dateReservation");
                emprinte.CodeOuvrague = reader.GetString("codeOuvrague");
                emprinte.NomUtilisateurEmprenteur = reader.GetString("nomUtilisateur_emprenteur");

                emprintes.Add(emprinte);
            }

            return emprintes.ToArray();
        }

        public Emprinte[] mesReservation(Compte compte)
        {
            RequeteOuvragueExe roe = new RequeteOuvragueExe();

            MySqlDataReader reader = roe.mesReservation(compte);
            List<Emprinte> emprintes = new List<Emprinte>();

            while (reader.Read())
            {
                Emprinte emprinte = new Emprinte();

                emprinte.NumeroEmprinte = reader.GetInt32("numSeq");
                emprinte.DateReservation = reader.GetString("dateReservation");
                emprinte.CodeOuvrague = reader.GetString("codeOuvrague");
                emprinte.NomUtilisateurEmprenteur = reader.GetString("nomUtilisateur_emprenteur");

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

        public bool reserverOuvrague(Compte compte, string codeOuvrague)
        {
            RequeteOuvragueExe roe = new RequeteOuvragueExe();
            return roe.reserverOuvrague(compte, codeOuvrague);
        }

        public bool validerReservation(int numeroEmprente)
        {
            RequeteOuvragueExe roe = new RequeteOuvragueExe();
            return roe.validerReservation(numeroEmprente);
        }

    }
}
