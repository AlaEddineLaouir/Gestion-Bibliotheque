using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceFournis
{
    public interface ServiceClientCompte
    {
        CompteEtudiant seConnecterEtudaint(String nomUtilisateur, String motPasse);
        CompteEnseigant seConnecterEnseignant(String nomUtilisateur, String motPasse);
        Boolean creeCompteEtudiant(CompteEtudiant c);
        Boolean creeCompteEnseignant(CompteEnseigant c);
        Boolean modifierCompteEtudiant(String nomUtilisateur, CompteEtudiant compteNouveau);
        Boolean modifierCompteEnseignant(String nomUtilisateur, CompteEnseigant compteNouveau);
        
        Boolean verifierNomUtilisateur(String nomUtilisateur);
        Boolean verifierNumeroCarte(String numeroCarte);
        Boolean verifierMatrecule(String matrecule);
    }
}
