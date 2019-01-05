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
        public static String modifierOuvrague()
        {
            String requete = "update ouvrague set code=@cd , typeOuvrague=@to , theme=@thm , auteur=@atr , titre=@ttr ";
            requete += " where code=@cdP";
            return requete;
        }
        public static String validerCode()
        {
            String requete = "select etat from ouvrague where code like @cd";
            return requete;
        }
        //Modifier etat Ouvrage
        public static String etatNonDispoOuvrague()
        {
            String requete = "update ouvrague set etat='Non Disponible' ";
            requete += " where code=@cd";
            return requete;
        }
        public static String etatDispoOuvrague()
        {
            String requete = "update ouvrague set etat='Disponible' ";
            requete += " where code = @cd";
            return requete;
        }
        public static String etatReserverOuvrage()
        {
            String requete = "update ouvrague set etat='Reserver' ";
            requete += " where code=@cd";
            return requete;
        }
        public static String etatEmprenterOuvrague()
        {
            String requete = "update ouvrague set etat='Emprenter' ";
            requete += " where code=@cd";
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
            String requete = " select code,typeOuvrague,theme,auteur,titre,etat from ouvrague where code like '%"+cle+ "%' or typeOuvrague like '%" + cle + "%' ";
            requete += " or theme like '%" + cle + "%' or auteur like '%" + cle + "%' or titre like '%" + cle + "%' ";
            return requete;
        }
        public static String reserverOuvrague()
        {
            String requete = "insert into emprente (codeOuvrague,nomUtilisateur_emprenteur,dateReservation) ";
            requete += " values (@cdO,@nu,now())";
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
        public static String terminerEmprente()
        {
            String requete = "update emprente set dateRendemant=now() where numSeq=@nmsq ";
            return requete;
        }

        public static String listEmprinte()
        {
            //String requete = "select numSeq,dateReservation,nomUtilisateur_emprenteur,codeOuvrague from emprente where codeOuvrague IN (select code from ouvrague where etat = false) and valider=true and dateReservation  between date_sub(now(), interval 2 week) and date_sub(now(), interval -2 week);";
            String requete = "select numSeq,dateReservation,nomUtilisateur_emprenteur,codeOuvrague from emprente where dateRendemant is null and  codeOuvrague IN (select code from ouvrague where etat = 'Emprenter') and valider=true ;";

            return requete;
        }
        public static String listReservation()
        {
            //String requete = "select numSeq,dateReservation,nomUtilisateur_emprenteur,codeOuvrague from emprente where valider=false and dateReservation  between date_sub(now(), interval 1 day) and date_sub(now(), interval -1 day);  ";
            String requete = "select numSeq,dateReservation,nomUtilisateur_emprenteur,codeOuvrague from emprente where codeOuvrague IN (select code from ouvrague where etat = 'Reserver') and valider=false ;  ";

            return requete;
        }
        public static  String  mesReservation()
        {
            //String requete = "select numSeq,dateReservation,nomUtilisateur_emprenteur,codeOuvrague from emprente where nomUtilisateur_emprenteur=@nu and valider=false and dateReservation  between date_sub(now(), interval 1 day) and date_sub(now(), interval -1 day);  ";
            String requete = "select numSeq,dateReservation,nomUtilisateur_emprenteur,codeOuvrague from emprente where codeOuvrague IN (select code from ouvrague where etat = 'Reserver') and nomUtilisateur_emprenteur=@nu and valider=false ;  ";

            return requete;
        }
        public static String mesEmperente()
        {
            String requete = "select numSeq,dateReservation,nomUtilisateur_emprenteur,codeOuvrague from emprente where dateRendemant is null and codeOuvrague IN (select code from ouvrague where etat = 'Emprenter') and nomUtilisateur_emprenteur=@nu and valider=true ;";
            return requete;
        }

        public static String reservationExpirer()
        {
            String requete = "select numSeq , codeOuvrague,e.nomUtilisateur_emprenteur from Emprente e  where ";
            requete += " valider=false and dateReservation not between date_sub(now(), interval 1 day) and date_sub(now(), interval -1 day) ";
            return requete;
        }
        public static String viderlistattente()
        {
            String requete = "delete from list_attente_ouvrague where codeOuvrague=@cdO ;";
            return requete;
        }
        public static String listAttenteOuvrague()
        {
            String requete = "select email from Etudiant e, list_attente_ouvrague lao where ";
            requete += " lao.codeOuvrague=@cdO and lao.nomUtilisateur_emprenteur=e.nomUtilisateur ";
            requete += " Union  ";
            requete = "select email from Enseignant e, list_attente_ouvrague lao where ";
            requete += " lao.codeOuvrague=@cdO and lao.nomUtilisateur_emprenteur=e.nomUtilisateur";
            return requete;
        }
        public static String supprimerReservation()
        {
            String requete = "delete from emprente where numSeq=@nmsq ";
            return requete;
        }


    }
}
