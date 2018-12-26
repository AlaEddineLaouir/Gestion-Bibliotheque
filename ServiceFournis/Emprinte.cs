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

        public Emprinte(string dateReservation, bool valider, string nomUtilisateurEmprenteur, string codeOuvrague)
        {
            this.DateReservation = dateReservation;
            this.Valider = valider;
            this.NomUtilisateurEmprenteur = nomUtilisateurEmprenteur;
            this.CodeOuvrague = codeOuvrague;
        }

        public string DateReservation { get => dateReservation; set => dateReservation = value; }
        public bool Valider { get => valider; set => valider = value; }
        public string NomUtilisateurEmprenteur { get => nomUtilisateurEmprenteur; set => nomUtilisateurEmprenteur = value; }
        public string CodeOuvrague { get => codeOuvrague; set => codeOuvrague = value; }
    }
}
