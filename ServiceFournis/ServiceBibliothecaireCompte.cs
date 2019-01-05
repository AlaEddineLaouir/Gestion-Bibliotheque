using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace ServiceFournis
{
    public interface ServiceBibliothecaireCompte
    {
        Compte[] chercherCompteEtudiant(String cle);
        Compte[] chercherCompteEnseignant(String cle);
        Boolean creeCompteEtudiant(CompteEtudiant c);
        Boolean creeCompteEnseignant(CompteEnseigant c);
        Boolean modifierCompteEtudiant(String nomUtilisateur , CompteEtudiant compteNouveau);
        Boolean modifierCompteEnseignant(String nomUtilisateur, CompteEnseigant compteNouveau);
        
        Boolean verifierNomUtilisateur(String nomUtilisateur);
        Boolean verifierNumeroCarte(String numeroCarte);
        Boolean verifierMatrecule(String matrecule);
    }
}
