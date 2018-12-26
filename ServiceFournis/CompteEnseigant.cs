using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceFournis
{
    [Serializable]
    public class CompteEnseigant : Compte
    {
       
        private String grade;
        private String matrecule;
        private String email;
        public CompteEnseigant(string nom_utilisteur, string mot_passe, string nom, string prenom, string grade, string matrecule , string email) : base(nom_utilisteur,mot_passe,nom,prenom)
        {
            this.Email = email; 
            this.Grade = grade;
            this.Matrecule = matrecule;
        }

       
        public string Grade { get => grade; set => grade = value; }
        public string Matrecule { get => matrecule; set => matrecule = value; }
        public string Email { get => email; set => email = value; }
    }
}
