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
    public class Emprinte
    {
        [DataMember] private String dateReservation;
        [DataMember] private bool valider;
        [DataMember] private String nomUtilisateurEmprenteur;
        [DataMember] private String codeOuvrague;
        [DataMember] private String numeroEmprinte;
        

        public string DateReservation { get => dateReservation; set => dateReservation = value; }
        public bool Valider { get => valider; set => valider = value; }
        public string NomUtilisateurEmprenteur { get => nomUtilisateurEmprenteur; set => nomUtilisateurEmprenteur = value; }
        public string CodeOuvrague { get => codeOuvrague; set => codeOuvrague = value; }
        public String NumeroEmprinte { get => numeroEmprinte; set => numeroEmprinte = value; }
    }
}
