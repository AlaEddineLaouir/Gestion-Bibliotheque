using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ServiceFournis
{
    [Serializable]
    [DataContract]
    public class Compte
    {

        [DataMember] private Boolean compteEtudiant;
        [DataMember] protected String nom_utilisteur;
        [DataMember] protected String mot_passe;
        [DataMember] protected String nom;
        [DataMember] protected String prenom;

        

        public string Nom_utilisteur { get => nom_utilisteur; set => nom_utilisteur = value; }
        public string Mot_passe { get => mot_passe; set => mot_passe = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        
        public bool CompteEtudiant { get => compteEtudiant; set => compteEtudiant = value; }
    }
}
