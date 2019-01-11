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
    public class CompteEtudiant : Compte
    {
        //Information de l'etudiant

        [DataMember] private String specialite;
        [DataMember] private String niveau;
        [DataMember] private String numeroCarte;
        [DataMember] private String email;

        
        public string Specialite { get => specialite; set => specialite = value; }
        public string Niveau { get => niveau; set => niveau = value; }
        public string NumeroCarte { get => numeroCarte; set => numeroCarte = value; }
        public string Email { get => email; set => email = value; }
    }
}
