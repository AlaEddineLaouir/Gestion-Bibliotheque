using System;
using MySql.Data.MySqlClient;
using ServiceFournis;
namespace Fournisseur_Service
{
    class RequeteCompteExe
    {
        private MySqlConnection cnx = new MySqlConnection("server=localhost;userid=root;password=admin;database=bibiotheque");

        public MySqlDataReader chercherEtudiant(String cle)
        {
           try
            {
                cnx.Open();
                MySqlCommand chercherEtudiant = cnx.CreateCommand();
                chercherEtudiant.CommandText = RequeteCompte.chercherCompteEtudiant(cle);
                return chercherEtudiant.ExecuteReader();
            }catch(Exception e)
            {
                return null;
            }finally
            {
                cnx.Dispose();
            }

        }

        public MySqlDataReader cherhcerEnseignant(String cle)
        {
            try
            {
                cnx.Open();
                MySqlCommand cherhcerEnseignant = cnx.CreateCommand();
                cherhcerEnseignant.CommandText = RequeteCompte.chercherCompteEnseignant(cle);
                return cherhcerEnseignant.ExecuteReader();
            }catch(Exception e)
            {
                return null;
            }finally
            {
                cnx.Dispose();
            }
        }

        public Boolean creeCompteEtudiant(CompteEtudiant c)
        {
            //cree une transaction car plusieur requete sont lieés
            MySqlTransaction tran=cnx.BeginTransaction();

            try
            {
                //Ouvre la connexion a la base de donnée
                cnx.Open();
                

                //Ajouter Empraenteur
                MySqlCommand ajouterEmpreteur = cnx.CreateCommand();
                ajouterEmpreteur.Transaction = tran;
                ajouterEmpreteur.CommandText = RequeteCompte.ajouterEmprenteur();
                ajouterEmpreteur.Parameters.Add("@nu", MySqlDbType.VarChar).Value = c.Nom_utilisteur;
                ajouterEmpreteur.Parameters.Add("@mp", MySqlDbType.VarChar).Value = c.Mot_passe;
                ajouterEmpreteur.ExecuteNonQuery();

                //Ajouter Info personnelle de l'etudiant
                MySqlCommand ajouterEtudiant = cnx.CreateCommand();
                ajouterEtudiant.CommandText = RequeteCompte.ajouterEtudiant();
                ajouterEtudiant.Transaction = tran;
                ajouterEtudiant.Parameters.Add("@nu", MySqlDbType.VarChar).Value = c.Nom_utilisteur;
                ajouterEtudiant.Parameters.Add("@nom", MySqlDbType.VarChar).Value = c.Nom;
                ajouterEtudiant.Parameters.Add("@prenom", MySqlDbType.VarChar).Value = c.Prenom;
                ajouterEtudiant.Parameters.Add("@numC", MySqlDbType.VarChar).Value = c.NumeroCarte;
                ajouterEtudiant.Parameters.Add("@spec", MySqlDbType.VarChar).Value = c.Specialite;
                ajouterEtudiant.Parameters.Add("@niv", MySqlDbType.VarChar).Value = c.Niveau;
                ajouterEtudiant.Parameters.Add("@email", MySqlDbType.VarChar).Value = c.Email;

                ajouterEtudiant.ExecuteNonQuery();

                tran.Commit();

                return true;
            }catch(Exception e)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                cnx.Dispose();
            }
        }

        public Boolean creeCompteEnseignant(CompteEnseigant c)
        {
            //cree une transaction car plusieur requete sont lieés
            MySqlTransaction tran = cnx.BeginTransaction();

            try
            {
                //Ouvre la connexion a la base de donnée
                cnx.Open();


                //Ajouter Empraenteur
                MySqlCommand ajouterEmpreteur = cnx.CreateCommand();
                ajouterEmpreteur.Transaction = tran;
                ajouterEmpreteur.CommandText = RequeteCompte.ajouterEmprenteur();
                ajouterEmpreteur.Parameters.Add("@nu", MySqlDbType.VarChar).Value = c.Nom_utilisteur;
                ajouterEmpreteur.Parameters.Add("@mp", MySqlDbType.VarChar).Value = c.Mot_passe;
                ajouterEmpreteur.ExecuteNonQuery();

                //Ajouter Info personnelle de l'enseignant
                MySqlCommand ajouterEnseignant = cnx.CreateCommand();
                ajouterEnseignant.CommandText = RequeteCompte.ajouterEtudiant();
                ajouterEnseignant.Transaction = tran;
                ajouterEnseignant.Parameters.Add("@nu", MySqlDbType.VarChar).Value = c.Nom_utilisteur;
                ajouterEnseignant.Parameters.Add("@nom", MySqlDbType.VarChar).Value = c.Nom;
                ajouterEnseignant.Parameters.Add("@prenom", MySqlDbType.VarChar).Value = c.Prenom;
                ajouterEnseignant.Parameters.Add("@mat", MySqlDbType.VarChar).Value = c.Matrecule;
                ajouterEnseignant.Parameters.Add("@grd", MySqlDbType.VarChar).Value = c.Grade;
                ajouterEnseignant.Parameters.Add("@email", MySqlDbType.VarChar).Value = c.Email;

                ajouterEnseignant.ExecuteNonQuery();

                tran.Commit();

                return true;
            }
            catch (Exception e)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                cnx.Dispose();
            }

        }

        public Boolean modifierCompteEtudiant(String nomUtilisateur, CompteEtudiant c)
        {
            
            MySqlTransaction tran = cnx.BeginTransaction();
            try
            {
                cnx.Open();

                MySqlCommand modifierLogin = cnx.CreateCommand();
                modifierLogin.Transaction = tran;
                modifierLogin.CommandText = RequeteCompte.modifierCompte();

                modifierLogin.Parameters.Add("@nu", MySqlDbType.VarChar).Value = c.Nom_utilisteur;
                modifierLogin.Parameters.Add("@mp", MySqlDbType.VarChar).Value = c.Mot_passe;
                modifierLogin.Parameters.Add("@nuP", MySqlDbType.VarChar).Value = nomUtilisateur;
                modifierLogin.ExecuteNonQuery();

                MySqlCommand modifierInfoEtudiant = cnx.CreateCommand();
                modifierInfoEtudiant.Transaction = tran;
                modifierInfoEtudiant.CommandText = RequeteCompte.modifierCompteEtudiant();

                modifierInfoEtudiant.Parameters.Add("@nom", MySqlDbType.VarChar).Value = c.Nom;
                modifierInfoEtudiant.Parameters.Add("@prenom", MySqlDbType.VarChar).Value = c.Prenom;
                modifierInfoEtudiant.Parameters.Add("@spec", MySqlDbType.VarChar).Value = c.Specialite;
                modifierInfoEtudiant.Parameters.Add("@niv", MySqlDbType.VarChar).Value = c.Niveau;
                modifierInfoEtudiant.Parameters.Add("@email", MySqlDbType.VarChar).Value = c.Email;
                modifierInfoEtudiant.Parameters.Add("@nuP", MySqlDbType.VarChar).Value = c.Nom_utilisteur;

                modifierInfoEtudiant.ExecuteNonQuery();
                tran.Commit();

                return true;
            }catch(Exception e )
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                cnx.Dispose();
            }
        }

        public Boolean modiferCompteEnseignant(String nomUtilisateur , CompteEnseigant c)
        {
            MySqlTransaction tran = cnx.BeginTransaction();
            try
            {
                cnx.Open();

                MySqlCommand modifierLogin = cnx.CreateCommand();
                modifierLogin.Transaction = tran;
                modifierLogin.CommandText = RequeteCompte.modifierCompte();

                modifierLogin.Parameters.Add("@nu", MySqlDbType.VarChar).Value = c.Nom_utilisteur;
                modifierLogin.Parameters.Add("@mp", MySqlDbType.VarChar).Value = c.Mot_passe;
                modifierLogin.Parameters.Add("@nuP", MySqlDbType.VarChar).Value = nomUtilisateur;
                modifierLogin.ExecuteNonQuery();

                MySqlCommand modifierInfoEnseignant = cnx.CreateCommand();
                modifierInfoEnseignant.Transaction = tran;
                modifierInfoEnseignant.CommandText = RequeteCompte.modifierCompteEtudiant();

                modifierInfoEnseignant.Parameters.Add("@nom", MySqlDbType.VarChar).Value = c.Nom;
                modifierInfoEnseignant.Parameters.Add("@prenom", MySqlDbType.VarChar).Value = c.Prenom;
                modifierInfoEnseignant.Parameters.Add("@grd", MySqlDbType.VarChar).Value = c.Grade;
                modifierInfoEnseignant.Parameters.Add("@email", MySqlDbType.VarChar).Value = c.Email;
                modifierInfoEnseignant.Parameters.Add("@nuP", MySqlDbType.VarChar).Value = c.Nom_utilisteur;

                modifierInfoEnseignant.ExecuteNonQuery();
                tran.Commit();

                return true;
            }
            catch (Exception e)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                cnx.Dispose();
            }

        }

        public Object seConnectEtudiant(String nomUtilisateur, String motPasse)
        {
            try
            {
                cnx.Open();
                MySqlCommand login = cnx.CreateCommand();
                login.CommandText = RequeteCompte.loginEtudiant();

                login.Parameters.Add("@nu", MySqlDbType.VarChar).Value = nomUtilisateur;
                login.Parameters.Add("@mp", MySqlDbType.VarChar).Value = motPasse;

                return login.ExecuteScalar();

            }catch(Exception e)
            {

                return null;
            }
            finally
            {
                cnx.Dispose();
            }
        }
        public Object seConnecterEnseignant(String nomUtilisateur , String motPasse)
        {
            try
            {
                cnx.Open();
                MySqlCommand login = cnx.CreateCommand();
                login.CommandText = RequeteCompte.loginEnseignant();

                login.Parameters.Add("@nu", MySqlDbType.VarChar).Value = nomUtilisateur;
                login.Parameters.Add("@mp", MySqlDbType.VarChar).Value = motPasse;

                return login.ExecuteScalar();

            }
            catch (Exception e)
            {

                return null;
            }
            finally
            {
                cnx.Dispose();
            }

        }
        public Boolean verifierNomUtilisateur(String nomUtilisateur)
        {
            try
            {
                cnx.Open();
                MySqlCommand verifier = cnx.CreateCommand();
                verifier.CommandText = RequeteCompte.verifierNomUtilisateur();

                verifier.Parameters.Add("@nu", MySqlDbType.VarChar).Value = nomUtilisateur;
                int count =(int) verifier.ExecuteScalar();

                if (count > 0)
                {
                    return false;
                }else
                {
                    return true;
                }
                
            }catch(Exception e)
            {
                return false;
            }finally
            {
                cnx.Dispose();
            }
        }

        public Boolean verifierNumeroCarte(String numCarte)
        {
            try
            {
                cnx.Open();
                MySqlCommand verifier = cnx.CreateCommand();
                verifier.CommandText = RequeteCompte.verifierNumCarte();

                verifier.Parameters.Add("@numC", MySqlDbType.VarChar).Value = numCarte;
                int count = (int)verifier.ExecuteScalar();

                if (count > 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                cnx.Dispose();
            }
        }

        public Boolean verifierMatrecule(String matrecule)
        {
            try
            {
                cnx.Open();
                MySqlCommand verifier = cnx.CreateCommand();
                verifier.CommandText = RequeteCompte.verfierMatrecule();

                verifier.Parameters.Add("@mat", MySqlDbType.VarChar).Value = matrecule;
                int count = (int)verifier.ExecuteScalar();

                if (count > 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                cnx.Dispose();
            }
        }


    }
}
