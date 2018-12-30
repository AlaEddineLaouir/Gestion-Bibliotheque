using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceFournis
{
    public interface ServiceBibliothecaireOuvrague
    {
        Ouvrague[] chercherOuvrague(String motCle);
        Boolean emprinterOuvrague(Compte compte, String codeOuvrague);
        Boolean validerReservation(Compte compte, String codeOuvrague);
        Boolean ajouterOuvrague(Ouvrague ouvrague);
        Boolean modifierOuvrague(Ouvrague ouvrague);
        Boolean renderOuvrague(Ouvrague ouvrague);
        Emprinte[] listReservation();
        Emprinte[] listEmprinte();
        Boolean nonDispoOuvrague(String codeOuvargue);
        Boolean dispoOuvrague(String codeOuvrague);
    }
}
