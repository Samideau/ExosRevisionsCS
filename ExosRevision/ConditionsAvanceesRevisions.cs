using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExosRevision
{
    public class ConditionsAvanceesRevisions
    {
        //Ecrire une fonction qui vérifie SI "valeur_utilisateur" est strictement plus grand que 0 
        // si c'est le cas : vérifier SI "valeur_utilisateur est plus petit ou égale à 10
        //      si c'est le cas : retourner 50
        //      SINON : retourner 25
        // SINON : retourner 0
        public int ConditionImbriquee(int valeur_utilisateur)
        {
            //-----Votre code ici --------




            return 9999;
            //----------------------------
        }

        /* Rappel sur les opérateurs de "liaison" des conditions
        * 
        * ET -> &&
        * variable == valeur && variable2 == valeur2
        * -> Les 2 comparaisons doivent être vraies pour "rentrer" dans le if
        * 
        * OU -> ||
        * variable == valeur || variable2 == valeur2
        * -> Au moins une des 2 comparaisons doit être vraie pour "rentrer" dans le if
        */


        //Ecrire une fonction qui vérifie SI "valeur_utilisateur" est strictement plus grand que 0 ET "valeur_utilisateur est plus petit ou égale à 10 (il n'y a qu'un seul "if" ici)
        // si c'est le cas : retourner 25
        // SINON : retourner 0
        public int DoubleCondition1(int valeur_utilisateur)
        {
            //-----Votre code ici --------





            return 9999;
            //----------------------------
        }

        //Ecrire une fonction qui vérifie SI "valeur_utilisateur" est strictement plus grand que 0 OU "valeur_utilisateur est plus petit ou égale à -10 (il n'y a qu'un seul "if" ici)
        // si c'est le cas : retourner 25
        // SINON : retourner 0
        public int DoubleCondition2(int valeur_utilisateur)
        {
            //-----Votre code ici --------





            return 9999;
            //----------------------------
        }

        //Ecrire une fonction qui vérifie SI "valeur_utilisateur" est strictement plus grand que 0
        // si c'est le cas : retourner 25
        // SINON : SI "valeur_utilisateur" est plus grand ou égale à -10
        //      si c'est le cas : retourner 50
        //      SINON : retourner 0
        public int ConditionSinonSupp(int valeur_utilisateur)
        {
            //-----Votre code ici --------





            return 9999;
            //----------------------------
        }

        //Ecrire une fonction qui vérifie SI "valeur_utilisateur" est strictement plus grand que 0 ET "valeur_utilisateur est plus petit ou égale à 10
        // si c'est le cas : retourner 25
        // SINON : SI "valeur_utilisateur" est strictement plus grand que 10 ET "valeur_utilisateur est plus petit ou égale à 20
        //      si c'est le cas : retourner 50
        //      SINON : retourner 0
        public int ConditionTotale(int valeur_utilisateur)
        {
            //-----Votre code ici --------





            return 9999;
            //----------------------------
        }
    }
}
