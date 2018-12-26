using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceFournis
{
    public interface ServiceClientOvrague
    {
        Ouvrague[] chercherOuvrague(String motCle);
        Boolean reserverOuvrague(Compte compte, String codeOuvrague);
        Boolean attendreOuvrague(Compte compte, String codeOuvrague);
        Emprinte[] mesReservation(Compte compte);
    }
}
