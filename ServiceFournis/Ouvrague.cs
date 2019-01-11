using System;
using System.Runtime.Serialization;

namespace ServiceFournis
{
    [Serializable]
    [DataContract]
    public class Ouvrague
    {
        [DataMember] private String typeOuvrague;
        [DataMember] private String theme;
        [DataMember] private String auteur;
        [DataMember] private String titre;
        [DataMember] private String code;
        [DataMember] private String etat;


       

        public string TypeOuvrague { get => typeOuvrague; set => typeOuvrague = value; }
        public string Theme { get => theme; set => theme = value; }
        public string Auteur { get => auteur; set => auteur = value; }
        public string Titre { get => titre; set => titre = value; }
        public string Code { get => code; set => code = value; }
        public String Etat { get => etat; set => etat = value; }
    }
}
