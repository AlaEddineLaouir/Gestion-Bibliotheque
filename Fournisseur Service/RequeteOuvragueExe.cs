using System;
using System.Data;
using MySql.Data.MySqlClient;
using ServiceFournis;
using System.Collections.Generic;
using System.Collections;

namespace Fournisseur_Service
{
    class RequeteOuvragueExe
    {
        private MySqlConnection cnx = new MySqlConnection("server=localhost;userid=root;password=admin;database=bibiotheque");
        
        public IDataReader chercherOuvrague(String motCle)
        {
            try
            {
                cnx.Open();
                MySqlCommand chercherOuvrague = cnx.CreateCommand();
                chercherOuvrague.CommandText = RequeteOuvrague.cherhcherOuvrague(motCle);

                DataTable dt = new DataTable();
                MySqlDataReader msdr= chercherOuvrague.ExecuteReader();
                dt.Load(msdr);
                return dt.CreateDataReader();

            }catch(Exception e )
            {
                Console.WriteLine(e.Message + "-----" + e.StackTrace);
                return null;
            }
            finally
            {
                cnx.Dispose();
            }
        }

        public IDataReader listEmprinte()
        {
            try
            {
                cnx.Open();
                MySqlCommand listEmprinte = cnx.CreateCommand();
                listEmprinte.CommandText = RequeteOuvrague.listEmprinte();
                
                DataTable dt = new DataTable();
                MySqlDataReader msdr = listEmprinte.ExecuteReader();
                dt.Load(msdr);
                return dt.CreateDataReader();
            }catch(Exception e)
            {
                Console.WriteLine(e.Message + "------" + e.StackTrace);
                return null;
            }
            finally
            {
                cnx.Dispose();
            }
        }

        public IDataReader listReservation()
        {
            try
            {
                cnx.Open();
                MySqlCommand listReservation = cnx.CreateCommand();
                listReservation.CommandText = RequeteOuvrague.listReservation();
                Console.WriteLine(listReservation.CommandText);
                DataTable dt = new DataTable();
                MySqlDataReader msdr = listReservation.ExecuteReader();
                dt.Load(msdr);
                return dt.CreateDataReader();

            }catch(Exception e)
            {
                Console.WriteLine(e.Message + "-----" + e.StackTrace);
                return null;
            }
            finally
            {
                cnx.Dispose();
            }
        }

        public IDataReader mesEmprente(Compte compte)
        {
            try
            {
                cnx.Open();
                MySqlCommand mesEmprinte = cnx.CreateCommand();
                mesEmprinte.CommandText = RequeteOuvrague.mesEmperente();
                mesEmprinte.Parameters.Add("@nu", MySqlDbType.VarChar).Value = compte.Nom_utilisteur;

                DataTable dt = new DataTable();
                MySqlDataReader msdr = mesEmprinte.ExecuteReader();
                dt.Load(msdr);
                return dt.CreateDataReader();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message + "-----" + e.StackTrace);
                return null;
            }
            finally
            {
                cnx.Dispose();
            }
        }

        public IDataReader mesReservation(Compte compte)
        {
            try
            {
                cnx.Open();
                MySqlCommand mesReservation = cnx.CreateCommand();
                mesReservation.CommandText = RequeteOuvrague.mesReservation();
                mesReservation.Parameters.Add("@nu", MySqlDbType.VarChar).Value = compte.Nom_utilisteur;

                DataTable dt = new DataTable();
                MySqlDataReader msdr = mesReservation.ExecuteReader();
                dt.Load(msdr);
                return dt.CreateDataReader();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "-----" + e.StackTrace);
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
                nonDispoOuvrague.CommandText = RequeteOuvrague.etatNonDispoOuvrague();

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

                dispoOuvrague.CommandText = RequeteOuvrague.etatDispoOuvrague();

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
                MySqlTransaction tran = cnx.BeginTransaction();

                MySqlCommand reserverOuvrague = cnx.CreateCommand();
                reserverOuvrague.Transaction = tran;
                reserverOuvrague.CommandText = RequeteOuvrague.reserverOuvrague();

                reserverOuvrague.Parameters.Add("@cdO", MySqlDbType.VarChar).Value = codeOuvrague;
                reserverOuvrague.Parameters.Add("@nu", MySqlDbType.VarChar).Value = compte.Nom_utilisteur;

                reserverOuvrague.ExecuteNonQuery();

                MySqlCommand changerEtatOuvrague = cnx.CreateCommand();
                changerEtatOuvrague.Transaction = tran;
                changerEtatOuvrague.CommandText = RequeteOuvrague.etatReserverOuvrage();
                changerEtatOuvrague.Parameters.Add("@cd", MySqlDbType.VarChar).Value = codeOuvrague;
                changerEtatOuvrague.ExecuteNonQuery();

                tran.Commit();
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

        public Boolean validerReservation(int numeroEmprente , String codeOuvrague)
        {
            try
            {
                cnx.Open();
                MySqlTransaction tran = cnx.BeginTransaction();

                MySqlCommand validerReservation = cnx.CreateCommand();
                validerReservation.Transaction = tran;

                validerReservation.CommandText = RequeteOuvrague.validerReservation();

                validerReservation.Parameters.Add("@nmsq", MySqlDbType.Int64).Value = numeroEmprente;

                validerReservation.ExecuteNonQuery();

                MySqlCommand changerEtatOuvrague = cnx.CreateCommand();
                changerEtatOuvrague.Transaction = tran;
                changerEtatOuvrague.CommandText = RequeteOuvrague.etatEmprenterOuvrague();
                changerEtatOuvrague.Parameters.Add("@cd",MySqlDbType.VarChar).Value=codeOuvrague;
                changerEtatOuvrague.ExecuteNonQuery();

                tran.Commit();


                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "-----" + e.StackTrace);
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
                MySqlTransaction tran = cnx.BeginTransaction();

                MySqlCommand emprenterOuvrague = cnx.CreateCommand();
                emprenterOuvrague.Transaction = tran;

                emprenterOuvrague.CommandText = RequeteOuvrague.emprinterOuvrague();

                emprenterOuvrague.Parameters.Add("@nu", MySqlDbType.VarChar).Value = compte.Nom_utilisteur;
                emprenterOuvrague.Parameters.Add("@cdO", MySqlDbType.VarChar).Value = codeOuvrague;

                int rowAffected =emprenterOuvrague.ExecuteNonQuery();

                MySqlCommand changerEtatOuvrague = cnx.CreateCommand();
                changerEtatOuvrague.Transaction = tran;
                changerEtatOuvrague.CommandText = RequeteOuvrague.etatEmprenterOuvrague();
                changerEtatOuvrague.Parameters.Add("@cd", MySqlDbType.VarChar).Value = codeOuvrague;
                rowAffected=changerEtatOuvrague.ExecuteNonQuery();

                tran.Commit();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "-----" + e.StackTrace);
                return false;
            }
            finally
            {
                cnx.Dispose();
            }
        }

        public String[] rendreOuvrague(Ouvrague ouvrague,int numEmprente)
        {
            List<String> listEmail = new List<String>();

            try
            {
                cnx.Open();

                MySqlTransaction tran = cnx.BeginTransaction();

                MySqlCommand dispoOuvrague = cnx.CreateCommand();
                dispoOuvrague.Transaction = tran;
                dispoOuvrague.CommandText = RequeteOuvrague.etatDispoOuvrague();
                dispoOuvrague.Parameters.Add("@cd", MySqlDbType.VarChar).Value = ouvrague.Code;
                dispoOuvrague.ExecuteNonQuery();


                MySqlCommand rendreOuvrague = cnx.CreateCommand();
                rendreOuvrague.Transaction = tran;

                rendreOuvrague.CommandText = RequeteOuvrague.terminerEmprente();
                rendreOuvrague.Parameters.Add("@nmsq", MySqlDbType.VarChar).Value = numEmprente;
                rendreOuvrague.ExecuteNonQuery();

                MySqlCommand emails = cnx.CreateCommand();

                emails.Transaction = tran;
                emails.CommandText = RequeteOuvrague.listAttenteOuvrague();
                emails.Parameters.Add("@cdO", MySqlDbType.VarChar).Value = ouvrague.Code;

                MySqlDataReader msdr = emails.ExecuteReader();

                while (msdr.Read())
                {
                    listEmail.Add(msdr.GetString("email"));
                }


                tran.Commit();
                return listEmail.ToArray();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "-----" + e.StackTrace);
                return null;
            }            
            finally
            {
                cnx.Dispose();
            }
        }

        public String validerCodeOuvrague(String codeOuvrague)
        {
            try
            {
                cnx.Open();
                MySqlCommand valider = cnx.CreateCommand();
                valider.CommandText = RequeteOuvrague.validerCode();
                valider.Parameters.Add("@cd", MySqlDbType.VarChar).Value = codeOuvrague;

                String resultat = valider.ExecuteScalar().ToString();

                return resultat;
               

            }catch(Exception e)
            {
                return "";
            }
            finally
            {
                cnx.Dispose();
            }
        }

        public IDataReader listReservationExpirer()
        {
            try
            {

               cnx.Open();

                MySqlCommand reservationExpirer = cnx.CreateCommand();
                reservationExpirer.CommandText = RequeteOuvrague.reservationExpirer();
                MySqlDataReader msdr = reservationExpirer.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(msdr);
                return dt.CreateDataReader();
            }catch(Exception e)
            {
                Console.WriteLine(e.Message + "-----" + e.StackTrace);
                return null;
            }
            finally
            {
                cnx.Dispose();
            }
        }

        public String[] listEmailAttente(String codeOuvrage)
        {
            
            List<String> listEmail = new List<String>();

           

                try
                {
                    cnx.Open();
                    MySqlCommand emails = cnx.CreateCommand();

                    emails.CommandText = RequeteOuvrague.listAttenteOuvrague();
                    emails.Parameters.Add("@cdO", MySqlDbType.VarChar).Value = codeOuvrage;

                    MySqlDataReader msdr = emails.ExecuteReader();

                    while (msdr.Read())
                    {
                        listEmail.Add(msdr.GetString("email"));
                    }

                }catch(Exception e)
                {
                    Console.WriteLine(e.Message + "-----" + e.StackTrace);
                    
                }
                finally
                {
                    cnx.Dispose();
                }
            


            return listEmail.ToArray();

            
        }

        public Boolean viderListAttenteOuvrague(String[] codeOuvrage)
        {
            try
            {
                cnx.Open();
                foreach (String code in codeOuvrage)
                {
                    MySqlCommand viderlist = cnx.CreateCommand();

                    viderlist.CommandText = RequeteOuvrague.viderlistattente();
                    viderlist.Parameters.Add("@cdO", MySqlDbType.VarChar).Value = code;

                    viderlist.ExecuteNonQuery();
                }
                return true;
            }catch(Exception e)
            {
                Console.WriteLine(e.Message + "-----" + e.StackTrace);
                return false;
            }finally
            {
                cnx.Dispose();
            }
        }

        public Boolean supprimerReservation(String[] numReservation)
        {
            try
            {
                cnx.Open();

                foreach (String num in numReservation)
                {
                    MySqlCommand supprimer = cnx.CreateCommand();

                    supprimer.CommandText = RequeteOuvrague.supprimerReservation();
                    supprimer.Parameters.Add("@nmsq", MySqlDbType.Int64).Value = Convert.ToUInt64(num);

                    supprimer.ExecuteNonQuery();
                }

                return true;
            }catch(Exception e)
            {
                Console.WriteLine(e.Message + "-----" + e.StackTrace);
                return false;
            }
            finally
            {
                cnx.Dispose();
            }
        }

    }
}
