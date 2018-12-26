using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceFournis
{
    public interface ServiceBibliothecaireCompte
    {
        Compte[] chercherCompte(String cle);
        Boolean creeCompte(Compte c);
        Boolean modifierCompte(String nomUtilisateur , Compte compteNouveau);
        Boolean supprimerCompte(Compte c);

    }
}
