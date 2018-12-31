using System;
using MySql.Data.MySqlClient;
using ServiceFournis;

namespace Fournisseur_Service
{
    class RequeteOuvragueExe
    {
        private MySqlConnection cnx = new MySqlConnection("server=localhost;userid=root;password=admin;database=bibiotheque");
        
        public MySqlDataReader chercherOuvrague(String motCle)
        {
            try
            {
                cnx.Open();
                MySqlCommand chercherOuvrague = cnx.CreateCommand();
                chercherOuvrague.CommandText = RequeteOuvrague.cherhcherOuvrague(motCle);
                return chercherOuvrague.ExecuteReader();

            }catch(Exception e )
            {
                return null;
            }
            finally
            {
                cnx.Dispose();
            }
        }

        public MySqlDataReader listEmprinte()
        {
            try
            {
                cnx.Open();
                MySqlCommand listEmprinte = cnx.CreateCommand();
                listEmprinte.CommandText = RequeteOuvrague.listEmprinte();
                return listEmprinte.ExecuteReader();
            }catch(Exception e)
            {
                return null;
            }
            finally
            {
                cnx.Dispose();
            }
        }

        public MySqlDataReader listReservation()
        {
            try
            {
                cnx.Open();
                MySqlCommand listReservation = cnx.CreateCommand();
                listReservation.CommandText = RequeteOuvrague.listReservation();
                return listReservation.ExecuteReader();

            }catch(Exception e)
            {
                return null;
            }
            finally
            {
                cnx.Dispose();
            }
        }

        public MySqlDataReader mesEmprente(Compte compte)
        {
            try
            {
                cnx.Open();
                MySqlCommand mesEmprinte = cnx.CreateCommand();
                mesEmprinte.CommandText = RequeteOuvrague.mesEmperente();
                mesEmprinte.Parameters.Add("@nu", MySqlDbType.VarChar).Value = compte.Nom_utilisteur;
                return mesEmprinte.ExecuteReader();

            }catch(Exception e)
            {
                return null;
            }
            finally
            {
                cnx.Dispose();
            }
        }

        public MySqlDataReader mesReservation(Compte compte)
        {
            try
            {
                cnx.Open();
                MySqlCommand mesReservation = cnx.CreateCommand();
                mesReservation.CommandText = RequeteOuvrague.mesReservation();
                mesReservation.Parameters.Add("@nu", MySqlDbType.VarChar).Value = compte.Nom_utilisteur;
                return mesReservation.ExecuteReader();

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

        public Boolean ajouterOuvrague(Ouvrague ouvrague)
        {
            try
            {
                cnx.Open();
                MySqlCommand ajouterOuvrague = cnx.CreateCommand();
                ajouterOuvrague.CommandText = RequeteOuvrague.ajouterOuvrague();

                ajouterOuvrague.Parameters.Add("@cd", MySqlDbType.VarChar).Value=ouvrague.Code;
                ajouterOuvrague.Parameters.Add("@to", MySqlDbType.VarChar).Value = ouvrague.TypeOuvrague;
                ajouterOuvrague.Parameters.Add("@thm", MySqlDbType.VarChar).Value = ouvrague.Theme;
                ajouterOuvrague.Parameters.Add("@atr", MySqlDbType.VarChar).Value = ouvrague.Auteur;
                ajouterOuvrague.Parameters.Add("@ttr", MySqlDbType.VarChar).Value = ouvrague.Titre;

                ajouterOuvrague.ExecuteNonQuery();


                return true;
            }catch(Exception e)
            {
                return false;
            }
            finally
            {
                cnx.Dispose();
            }
        }

        public Boolean modifierOuvrague(String codeOuvrague ,Ouvrague ouvrague)
        {
            try
            {
                cnx.Open();
                MySqlCommand modifierOuvrague = cnx.CreateCommand();

                modifierOuvrague.CommandText = RequeteOuvrague.modifierOuvrague();

                modifierOuvrague.Parameters.Add("@cd", MySqlDbType.VarChar).Value = ouvrague.Code;
                modifierOuvrague.Parameters.Add("@to", MySqlDbType.VarChar).Value = ouvrague.TypeOuvrague;
                modifierOuvrague.Parameters.Add("@thm", MySqlDbType.VarChar).Value = ouvrague.Theme;
                modifierOuvrague.Parameters.Add("@atr", MySqlDbType.VarChar).Value = ouvrague.Auteur;
                modifierOuvrague.Parameters.Add("@ttr", MySqlDbType.VarChar).Value = ouvrague.Titre;
                modifierOuvrague.Parameters.Add("@cdP", MySqlDbType.VarChar).Value = codeOuvrague;

                modifierOuvrague.ExecuteNonQuery();
                return true;
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

        public Boolean nonDispoOuvrague(String codeOuvrague)
        {
            try
            {
                cnx.Open();

                MySqlCommand nonDispoOuvrague = cnx.CreateCommand();
                nonDispoOuvrague.CommandText = RequeteOuvrague.nonDispoOuvrague();

                nonDispoOuvrague.Parameters.Add("@cd", MySqlDbType.VarChar).Value = codeOuvrague;

                nonDispoOuvrague.ExecuteNonQuery();

                return true;
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

        public Boolean dispoOuvrague(String codeOuvrague)
        {
            try
            {
                cnx.Open();

                MySqlCommand dispoOuvrague = cnx.CreateCommand();

                dispoOuvrague.CommandText = RequeteOuvrague.dispoOuvrague();

                dispoOuvrague.Parameters.Add("@cd", MySqlDbType.VarChar).Value = codeOuvrague;

                dispoOuvrague.ExecuteNonQuery();

                return true;
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

        public Boolean attendreOuvrague(Compte compte , String codeOuvrague)
        {
            try
            {
                cnx.Open();

                MySqlCommand attendreOuvrague = cnx.CreateCommand();

                attendreOuvrague.CommandText = RequeteOuvrague.attendreOuvrague();
                attendreOuvrague.Parameters.Add("@cdO", MySqlDbType.VarChar).Value = codeOuvrague;
                attendreOuvrague.Parameters.Add("@nu", MySqlDbType.VarChar).Value = compte.Nom_utilisteur;

                attendreOuvrague.ExecuteNonQuery();



                return true;
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

        public Boolean reserverOuvrague(Compte compte , String codeOuvrague)
        {
            try
            {
                cnx.Open();

                MySqlCommand reserverOuvrague = cnx.CreateCommand();
                reserverOuvrague.CommandText = RequeteOuvrague.reserverOuvrague();

                reserverOuvrague.Parameters.Add("@cdO", MySqlDbType.VarChar).Value = codeOuvrague;
                reserverOuvrague.Parameters.Add("@nu", MySqlDbType.VarChar).Value = compte.Nom_utilisteur;

                reserverOuvrague.ExecuteNonQuery();

                return true;
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

        public Boolean validerReservation(int numeroEmprente)
        {
            try
            {
                cnx.Open();

                MySqlCommand validerReservation = cnx.CreateCommand();

                validerReservation.CommandText = RequeteOuvrague.validerReservation();

                validerReservation.Parameters.Add("@nmsq", MySqlDbType.Int32).Value = numeroEmprente;

                validerReservation.ExecuteNonQuery();


                return true;
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

        public Boolean emprenterOuvrague(Compte compte, string codeOuvrague)
        {
            try
            {
                cnx.Open();

                MySqlCommand emprenterOuvrague = cnx.CreateCommand();

                emprenterOuvrague.CommandText = RequeteOuvrague.emprinterOuvrague();

                emprenterOuvrague.Parameters.Add("@nu", MySqlDbType.VarChar).Value = compte.Nom_utilisteur;
                emprenterOuvrague.Parameters.Add("@cdO", MySqlDbType.VarChar).Value = codeOuvrague;

                emprenterOuvrague.ExecuteNonQuery();

                return true;
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

        public Boolean rendreOuvrague(Ouvrague ouvrague)
        {
            try
            {
                cnx.Open();

                MySqlCommand rendreOuvrague = cnx.CreateCommand();

               
                return true;
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
