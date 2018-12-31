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
        

       
        public string Grade { get => grade; set => grade = value; }
        public string Matrecule { get => matrecule; set => matrecule = value; }
        public string Email { get => email; set => email = value; }
    }
}
