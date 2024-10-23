using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ExosRevision
{
    public class TableauxSimplesRevisions
    {
        /*      Rappel sur les Tableaux (Création)
        *    -----------------------------------------------
        * 
        * int[] variable = new int[4];
        *  
        * int -> indique le type de valeur qui sera contenue dans le tableau
        * [] -> indique que la variable sera un tableau
        * variable -> le nom du tableau
        * new int[...] -> permet de créer un nouveau tableau du type indiqué
        * 4 -> indique la taille du tableau
        * 
        * Ici, nous créons un tableau "variable" qui possède une taille de 4 et ne pourra contenir uniquement des valeurs de type "int"
        * Dans le cas ci-dessus, nous créons un tableau avec une taille fix sans indiquer des valeurs par défaut se trouvant à l'intérieur
        * Pour créer un tableau et l'initialiser directement avec des valeurs, il faut faire ceci :
        * 
        * int[] variable = { 0, 1, 2, 3};
        * 
        * Ici, nous créons un tableau "variable" qui possède une taille de 4, il ne pourra contenir uniquement des valeurs de type "int"
        * et les valeurs contenues dedans sont :
        * 1ere case : 0
        * 2eme case : 1
        * 3eme case : 2
        * 4eme case : 3
        * 
        * Pour copier l'intégralité d'un tableau vers un nouveau tableau, on peut faire ceci :
        * 
        * int[] ancien_tableau = {0, 1, 2, 3};
        * int[] variable = ancien_tableau; <--- Dans ce cas-ci, si on modifie les valeurs de "variable", les valeurs dans "ancien_tableau" sont égalements modifiées
        * 
        * ou ceci :
        * 
        * int[] ancien_tableau = {0, 1, 2, 3};
        * int[] variable = {ancien_tableau[0], ancien_tableau[1], ancien_tableau[2], ancien_tableau[3]}; 
        * 
        * Dans ce cas-ci, si on modifie les valeurs de "variable", les valeurs dans "ancien_tableau" ne sont pas modifiées
        */

        //Créer un tableau de "int" d'une taille 4 avec comme valeurs par défaut, de la première case vers la dernière : 
        //45, 21, 36, 95
        //Puis retourner ce nouveau tableau
        public int[] CreationTableau()
        {
            //-----Votre code ici --------    





            return new int[4];
            //----------------------------
        }

        //tableau_defaut = {0, 1, 2, 5}
        //Créer un tableau de "int" d'une taille 4 qui va s'initialiser avec le tableau "tableau_defaut"
        //Puis retourner ce nouveau tableau
        public int[] CopyTableau(int[] tableau_defaut)
        {
            //-----Votre code ici --------



            return new int[4];
            //----------------------------
        }

        /*  Rappel sur les Tableaux (Modification des valeurs)
        *    -----------------------------------------------  
        *
        * Nous avons le tableau : int[] variable = {45, 92, 65, 34}
        *
        * Comme vu au dessus
        * Ici, nous créons un tableau "variable" qui possède une taille de 4 et ne pourra contenir uniquement des valeurs de type "int"
        * 
        * Nous pouvons accéder directement à chaque valeur individuellement qui compose un tableau ainsi que de les modifier
        * Pour accéder à la toute première case qui contient la valeur 45, nous devons écrire :
        * 
        * variable[0];
        * 
        * variable -> nom du tableau
        * [0] -> le numéro de la case qu'on essaye d'accéder, la case (ou indice/index) 0 représente la toute 1ere case d'un tableau
        * 
        * Si on veut accéder à la 2eme case :
        * variable[1];
        * 
        * et ainsi de suite...
        * 
        * 
        * Pour modifier la valeur d'une case d'un tableau, il suffit d'indiquer la case qu'on veut modifier et remplacer cette valeur comme si c'était un simple int
        * Par exemple, on veut modifier la 3ème valeur du tableau :
        * 
        * variable[2] = 28;
        * on se retrouve donc avec le tableau "variable" qui contient les valeurs : {45, 92, 28, 34}
        * 
        * On peut également modifier la valeur à l'aide d'une autre variable ou même d'une autre valeur contenue dans un autre tableau
        * 
        * int valeur = 82;
        * variable[2] = valeur;
        * -> on se retrouve donc avec le tableau "variable" qui contient les valeurs : {45, 92, 82, 34}
        * 
        * int[] tableau = {0, 2, 4, 6}
        * variable[3] = tableau[0];
        * -> on se retrouve donc avec le tableau "variable" qui contient les valeurs : {45, 92, 82, 0}
        */

        //Créer un tableau de "int" d'une taille 4 avec comme valeurs par défaut, de la première case vers la dernière : 
        //64, 20, 48, 76
        //Puis retourner la 3ème valeur de ce nouveau tableau
        public int RecuperationValeurTableau1()
        {
            //-----Votre code ici --------    
            



            return 9999;
            //----------------------------
        }

        //Créer un tableau de "int" d'une taille 4 avec comme valeurs par défaut, de la première case vers la dernière : 
        //64, 20, 48, 76
        //Modifier la seconde valeur par 9645
        //Puis retourner la 2ème valeur de ce nouveau tableau
        public int RecuperationValeurTableau2()
        {
            //-----Votre code ici --------    
            



            return 9999;
            //----------------------------
        }

        //Créer un tableau de "int" d'une taille 4 avec comme valeurs par défaut, de la première case vers la dernière : 
        //64, 20, 48, 76
        //remplacer la dernière valeur de ce nouveau tableau par la valeur contenue dans la première case de "tableau_defaut"
        //Puis retourner la dernière valeur de ce nouveau tableau
        public int RecuperationValeurTableau3(int[] tableau_defaut)
        {
            //-----Votre code ici --------    




            return 9999;
            //----------------------------
        }

        //Créer un tableau de "int" d'une taille 4 avec comme valeurs par défaut, de la première case vers la dernière : 
        //64, 20, 48, 76
        //Créer une variable qui va contenir la somme de toutes les valeurs contenue dans le tableau (case 1 + case 2 + case 3 + case 4)
        //Puis retourner cette somme
        public int RecuperationValeurTableau4()
        {
            //-----Votre code ici --------    




            return 9999;
            //----------------------------
        }

        //Créer un tableau de "int" d'une taille 4 avec comme valeurs par défaut, de la première case vers la dernière : 
        //64, 20, 48, 76
        //remplacer la première valeur de ce nouveau tableau par la multiplication entre :
        //la valeur contenue dans la 3ème case de "tableau_defaut" ainsi que la valeur contenue dans la 1ère case de ce nouveau tableau
        //Puis retourner la 1ère valeur de ce nouveau tableau
        public int RecuperationValeurTableau5(int[] tableau_defaut)
        {
            //-----Votre code ici --------    




            return 9999;
            //----------------------------
        }

        //Créer un tableau de "int" d'une taille 4 avec comme valeurs par défaut, de la première case vers la dernière : 
        //64, 39, 48, 75

        //Additionner la 1ère valeur du nouveau tableau avec la valeur contenue dans la 1ère case de "tableau_defaut" et placer le résultat dans la 1ère case du nouveau tableau
        //Soustraire la 2eme valeur du nouveau tableau par la valeur contenue dans la 2ème case de "tableau_defaut" et placer le résultat dans la 2ème case du nouveau tableau
        //Multiplier la 3eme valeur du nouveau tableau avec la valeur contenue dans la 3ème case de "tableau_defaut" et placer le résultat dans la 3ème case du nouveau tableau
        //Diviser la dernière valeur du nouveau tableau par la valeur contenue dans la 4ème case de "tableau_defaut" et placer le résultat dans la 4ème case du nouveau tableau

        //Puis retourner ce nouveau tableau
        public int[] CreationModificationTableau(int[] tableau_defaut)
        {
            //-----Votre code ici --------    




            return new int[4];
            //----------------------------
        }
    }
}
