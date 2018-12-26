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

        public CompteEtudiant(string nom_utilisteur, string mot_passe, string nom, string prenom, string specialite, string niveau, string numeroCarte, string email) :base(nom_utilisteur,mot_passe,nom,prenom)
        {
            this.Email = email;
            this.Specialite = specialite;
            this.Niveau = niveau;
            this.NumeroCarte = numeroCarte;
        }

        public string Specialite { get => specialite; set => specialite = value; }
        public string Niveau { get => niveau; set => niveau = value; }
        public string NumeroCarte { get => numeroCarte; set => numeroCarte = value; }
        public string Email { get => email; set => email = value; }
    }
}
