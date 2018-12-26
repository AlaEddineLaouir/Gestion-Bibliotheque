using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fournisseur_Service
{
    class RequeteOuvrague
    {
        public static String ajouterOuvrague()
        {
            String requete = "insert into ouvrague (code,typeOuvrague,theme,auteur,titre) values ";
            requete += " (@cd,@to,@thm,@atr,@ttr);";
            return requete;
        }
        public static String attendreOuvrague()
        {
            String requete = "insert into list_attante_ouvrague(codeOuvrague,nomUtilisateur_emprenteur) ";
            requete += " values (@cdO,@nu);";
            return requete;
        }
        public static String cherhcherOuvrague(String cle)
        {
            String requete = " select * from ouvrague where code like '%"+cle+ "%' or typeOuvrague like '%" + cle + "%' ";
            requete += " or theme like '%" + cle + "%' or auteur like '%" + cle + "%' or titre like '%" + cle + "%' ";
            return requete;
        }
        public static String validerReservation()
        {
            String requete = "update emprente set valider= true where numSeq=@nmsq ;";
            return requete;
        }
        public static String emprinterOuvrague()
        {
            String requete = "insert into emprente (dateReservation,valider,nomUtilisateur_emprenteur,codeOuvrague) ";
            requete += " values (Now(),true,@nu,@cdO);";
            return requete;
        }
        public static String listEmprinte()
        {
            String requete = "select * from emprente where valider=true and dateReservation  between date_sub(now(), interval 2 week) and date_sub(now(), interval -2 week);";
            return requete;
        }
        public static String listReservation()
        {
            String requete = "select * from emprente where valider=false and dateReservation  between date_sub(now(), interval 1 day) and date_sub(now(), interval -1 day);  ";
            return requete;
        }
        public static  String  

        
    }
}
