using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceFournis;
using System.Net.Mail;

namespace Fournisseur_Service
{
    class EmailSender
    {

        private String[] emails;
        private String codeOuvrage;

        public string[] Emails { get => emails; set => emails = value; }
        public string CodeOuvrage { get => codeOuvrage; set => codeOuvrage = value; }

        public void avertire()
        {
            Task.Factory.StartNew(new Action(envoieMail));
        }
        private void envoieMail()
        {
            try
            {
                foreach (String email in Emails)
                {
                    MailMessage mail = new MailMessage("mehdi.alaeddine25@gmail.com", email);
                    SmtpClient client = new SmtpClient();
                    client.Port = 25;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                    client.Host = "smtp.gmail.com";
                    mail.Subject = "Ouvrage qui vous interesse .";
                    mail.Body = "l'ouvrage de code " + CodeOuvrage + " est maintenant disponible";
                    client.Send(mail);
                }
            }
            catch (Exception e)
            {
                
            }
            
        }
    }
}
