using System;

namespace Fournisseur_Service
{
    class RequeteCompte
    {
        public static String chercherCompteEtudiant(String cle)
        {
            String requete = "select e.nomUtilisateur,numCarte,nom,prenom,specialite,niveua,email from emprenteur e , etudiant et where e.nomutilisateur=et.nomUtilisateur and  ";
            requete += " (e.nomUtilisateur like '%"+cle+"%' or et.nom like '%"+cle+"%' or et.prenom like '%"+cle+"%' ";
            requete += " Or numCarte like '%"+cle+"%' or specialite like '%"+cle+"%' or niveua like '%"+cle+"%' )";
            return requete;
        }

        public static String chercherCompteEnseignant(String cle)
        {
            String requete = "select e.nomUtilisateur,matricule,nom,prenom,grade,email  from emprenteur e , Enseignant et where e.nomutilisateur=et.nomUtilisateur and";
            requete += " ( e.nomUtilisateur like '%" + cle + "%' or et.nom like '%" + cle + "%' or et.prenom like '%" + cle + "%' ";
            requete += " Or matricule like '%" + cle + "%' or grade like '%" + cle + "%' )";
            return requete;
        }
        public static String ajouterEmprenteur()
        {
            String requete="insert into emprenteur(nomUtilisateur,motdepasse) values (@nu,@mp) ;";
            return requete;
        }
        public static String ajouterEtudiant()
        {
            String requete = "insert into etudiant(nomUtilisateur,nom,prenom,numCarte,Specialite,niveua,email) values ";
            requete += "(@nu,@nom,@prenom,@numC,@spec,@niv,@email);";   
            return requete;
        }
        public static String ajouterEnseignant()
        {
            String requete = "insert into  Enseignant(nomUtilisateur,nom,prenom,matricule,grade,email) values ";
            requete += " (@nu,@nom,@prenom,@mat,@grd,@email) ;";
            return requete;
        }
        public static String modifierCompteEtudiant()
        {
            String requete = "update Etudiant set nom=@nom , prenom=@prenom , specialite=@spec , niveua=@niv ";
            requete += " , email=@email where nomUtilisateur=@nuP ";
            return requete;
        }
        public static String modifierCompteEnsignant()
        {
            String requete = "update Enseignant set nom=@nom , prenom=@prenom , grade=@grd  ";
            requete += " , email=@email , matricule=@mat where nomUtilisateur=@nuP ";
            return requete;
        }
        public static String modifierCompte()
        {
            String requete= "update Emprenteur set nomUtilisateur = @nu , motDePasse = @mp where nomUtilisateur = @nuP";
            return requete;
        }
        public static String verifierNomUtilisateur()
        {
            String requete = "select count(nomUtilisateur) from emprenteur where nomUtilisateur like @nu ;";
            return requete;
        }
        public static String emprenteurBanner()
        {
            String requete = "selcet banner from Emprenteur where nomutilisateur=@nu ";
            return requete;
        }
        public static String loginEtudiant()
        {
            String requete = "select * from Emprenteur e ,Etudiant et where e.nomutilisateur=@nu and e.motdepasse=@mp  ";
            requete += " and e.nomUtilisateur=et.nomUtilisateur";
            return requete;
        }
        public static String loginEnseignant()
        {
            String requete = "select * from Emprenteur e ,Enseignant et where e.nomutilisateur=@nu and e.motdepasse=@mp and ";
            requete += " e.nomUtilisateur=et.nomUtilisateur";
            return requete;
        }

        public static String activationCompte()
        {
            String requete = "update emprenteur set activer=@etat where nomUtilsateur=@nu";
            return requete;
        }

       

        public static String bannerEmprenteur()
        {
            String requete = "update emprenteur set numbreFausseReservation=numbreFausseReservation+1 where nomUtilisateur=@nu ";
            return requete;
        }
        public static String verifierNumCarte()
        {
            String requete = "Select count(numCarte) from etudiant where numCarte=@numC ";
            return requete;
        }
        public static String verfierMatrecule()
        {
            String requete = "Select count(matricule) from enseignant where matricule=@mat";
            return requete;
        }
        

    }
}
