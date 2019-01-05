using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceFournis
{
    [Serializable]
    public class Emprinte
    {
        private String dateReservation;
        private bool valider;
        private String nomUtilisateurEmprenteur;
        private String codeOuvrague;
        private String numeroEmprinte;
        

        public string DateReservation { get => dateReservation; set => dateReservation = value; }
        public bool Valider { get => valider; set => valider = value; }
        public string NomUtilisateurEmprenteur { get => nomUtilisateurEmprenteur; set => nomUtilisateurEmprenteur = value; }
        public string CodeOuvrague { get => codeOuvrague; set => codeOuvrague = value; }
        public String NumeroEmprinte { get => numeroEmprinte; set => numeroEmprinte = value; }
    }
}
