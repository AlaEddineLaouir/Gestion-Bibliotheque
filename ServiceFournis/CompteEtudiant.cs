using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceFournis
{
    [Serializable]
    public class CompteEtudiant : Compte
    {
        //Information de l'etudiant
        
        private String specialite;
        private String niveau;
        private String numeroCarte;
        private String email;

        
        public string Specialite { get => specialite; set => specialite = value; }
        public string Niveau { get => niveau; set => niveau = value; }
        public string NumeroCarte { get => numeroCarte; set => numeroCarte = value; }
        public string Email { get => email; set => email = value; }
    }
}
