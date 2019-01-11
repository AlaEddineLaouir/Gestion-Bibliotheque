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
    public class CompteEnseigant : Compte
    {

        [DataMember] private String grade;
        [DataMember] private String matrecule;
        [DataMember] private String email;
        

       
        public string Grade { get => grade; set => grade = value; }
        public string Matrecule { get => matrecule; set => matrecule = value; }
        public string Email { get => email; set => email = value; }
    }
}
