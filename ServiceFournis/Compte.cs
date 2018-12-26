﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceFournis
{
    [Serializable]
    public class Compte
    {
        
        private Boolean compteEtudiant;
        protected String nom_utilisteur;
        protected String mot_passe;
        protected String nom;
        protected String prenom;

        public Compte(string nom_utilisteur, string mot_passe, string nom, string prenom)
        {
            this.Nom_utilisteur = nom_utilisteur;
            this.Mot_passe = mot_passe;
            this.Nom = nom;
            this.Prenom = prenom;
        }

        public string Nom_utilisteur { get => nom_utilisteur; set => nom_utilisteur = value; }
        public string Mot_passe { get => mot_passe; set => mot_passe = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        
        public bool CompteEtudiant { get => compteEtudiant; set => compteEtudiant = value; }
    }
}