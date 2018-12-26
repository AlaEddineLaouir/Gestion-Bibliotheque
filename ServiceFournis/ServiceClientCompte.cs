using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceFournis
{
    public interface ServiceClientCompte
    {
        Compte seConnecter(String nomUtilisateur, String motPasse);
        Compte creeCompte(Compte compte);
        Boolean modifierCompte(String nomUtilisateur ,Compte compteNouveau);
    }
}
