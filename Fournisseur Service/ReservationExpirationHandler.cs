using System;
using System.Timers;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using ServiceFournis;
namespace Fournisseur_Service
{
    class ReservationExpirationHandler
    {

        public static void start()
        {
            Timer aTimer = new Timer(60*60*1000);
            aTimer.Elapsed += new ElapsedEventHandler(handler);
            aTimer.Enabled = true;

            Console.WriteLine("Service de Gestion validation de reservation est activer");
            
        }
        private static void handler(Object source , ElapsedEventArgs e)
        {

            Console.WriteLine(" Verification des Reservation demarer ");

            Emprinte[] reservationExpirer = listReservationExpirer();

            List<String> empreteurPenaliser = new List<String>();
            List<String> ouvrageLiberer = new List<String>();
            List<String> numeroReservationSupprimer = new List<String>();
            

            foreach (Emprinte emprente in reservationExpirer )
            {
                empreteurPenaliser.Add(emprente.NomUtilisateurEmprenteur);
                ouvrageLiberer.Add(emprente.CodeOuvrague);
                numeroReservationSupprimer.Add(emprente.NumeroEmprinte);
            }


            penaliserLesEmprenteur(empreteurPenaliser);

            supprimerReservation(numeroReservationSupprimer);

            avertireListeAttente(ouvrageLiberer);

            viderListeAttente(ouvrageLiberer);

            

        }

        private static Emprinte[] listReservationExpirer()
        {
            RequeteOuvragueExe roe = new RequeteOuvragueExe();
            IDataReader idr= roe.listReservationExpirer();

            List<Emprinte> listEmprente = new List<Emprinte>();

            while (idr.Read())
            {
                Emprinte e = new Emprinte();

                e.NumeroEmprinte = Convert.ToString(idr.GetInt64(0));
                e.CodeOuvrague = idr.GetString(1);
                e.NomUtilisateurEmprenteur = idr.GetString(2);

                listEmprente.Add(e);
            }
            return listEmprente.ToArray();

        }

        private static void penaliserLesEmprenteur(List<String> emprinteurs)
        {
            RequeteCompteExe rce = new RequeteCompteExe();
            rce.bannerEmprenteurs(emprinteurs.ToArray());
        }

        private static List<String> recupirerEmailAttente(String codeOuvrage)
        {
            RequeteOuvragueExe roe = new RequeteOuvragueExe();
            String[] emails=roe.listEmailAttente(codeOuvrage);

            return new List<String>(emails);
        }

        private static void supprimerReservation(List<String> numReservation)
        {
            RequeteOuvragueExe roe = new RequeteOuvragueExe();
            roe.supprimerReservation(numReservation.ToArray());
        }

        private static void viderListeAttente(List<String> codeOuvrage)
        {
            RequeteOuvragueExe roe = new RequeteOuvragueExe();
            roe.viderListAttenteOuvrague(codeOuvrage.ToArray());
        }

        private static void avertireListeAttente(List<String> ouvrage)
        {
            foreach (String code in ouvrage)
            {
                List<String> emailAvertire = new List<String>();
                emailAvertire = recupirerEmailAttente(code);

                EmailSender es = new EmailSender();

                es.Emails = emailAvertire.ToArray();
                es.CodeOuvrage = code;

                es.avertire();
            }
        }
    }
}
