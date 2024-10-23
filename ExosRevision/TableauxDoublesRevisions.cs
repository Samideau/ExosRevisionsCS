using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExosRevision
{
    public class TableauxDoublesRevisions
    {
        /*          Rappel sur les doubles Tableaux
        *    -----------------------------------------------  
        *
        * les tableaux simples sont souvent représenté par un rectangle (1 seule ligne, avec 1 ou plusieurs colonnes)
        * 
        * int[] variable = {0, 1, 2, 3} --> |0|1|2|3|
        * ici, la valeur 0 se trouve à la ligne "0" et la colonne "0" (rappel, les tableaux commencent TOUJOURS à l'indice 0)
        *      la valeur 1 se trouve à la ligne "0" et la colonne "1"
        *      la valeur 2 se trouve à la ligne "0" et la colonne "2"
        *      la valeur 3 se trouve à la ligne "0" et la colonne "3"
        * 
        * Les doubles tableaux (ou tableaux à 2 dimensions) permettent de rajouter des "lignes" aux tableaux simples !
        * 
        * int[,] variable = new int[3,4];
        * -> Tableaux 2D possédant le nom "variable", qui contient 3 lignes et 4 colonnes, toutes les cases de ce tableau sont initialisées à 0
        * 
        * 
        *                     
        *                      1ère ligne      2ème ligne       3ème ligne 
        * int[,] variable = {{ 0, 1, 2, 3 }, { 4, 5, 6, 7 }, { 8, 9, 10, 11 } };
        * -> Tableaux 2D possédant le nom "variable", qui contient 3 lignes et 4 colonnes, toutes les cases de ce tableau sont initialisées avec les valeurs indiquées
        * 
        * ce qui peut être représenté par :
        * |0 |1 |2 |3 |
        * |4 |5 |6 |7 |
        * |8 |9 |10|11|                             
        * 
        * (rappel, les tableaux commencent TOUJOURS à l'indice 0)
        * ici, la valeur 0 se trouve à la ligne "0" et la colonne "0"  -> variable[0][0]
        *      la valeur 1 se trouve à la ligne "0" et la colonne "1"  -> variable[0][1]
        *      la valeur 2 se trouve à la ligne "0" et la colonne "2"  -> variable[0][2]
        *      la valeur 3 se trouve à la ligne "0" et la colonne "3"  -> variable[0][3]
        *      la valeur 4 se trouve à la ligne "1" et la colonne "0"  -> variable[1][0]
        *      la valeur 5 se trouve à la ligne "1" et la colonne "1"  -> variable[1][1]
        *      la valeur 6 se trouve à la ligne "1" et la colonne "2"  -> variable[1][2]
        *      la valeur 7 se trouve à la ligne "1" et la colonne "3"  -> variable[1][3]
        *      la valeur 8 se trouve à la ligne "2" et la colonne "0"  -> variable[2][0]
        *      la valeur 9 se trouve à la ligne "2" et la colonne "1"  -> variable[2][1]
        *      la valeur 10 se trouve à la ligne "2" et la colonne "2" -> variable[2][2]
        *      la valeur 11 se trouve à la ligne "2" et la colonne "3" -> variable[2][3]
        * 
        * on remarque alors, qu'ici, nous avons 3 tableaux d'une taille 4, stocké dans une seule variable
        * 
        * 
        * Les opérations qu'on peut faire sur les tableaux simples, peuvent être également effectuées sur les tableaux doubles
        */

        //Créer un double tableau de "int" possédant 3 lignes et 4 colonnes, avec comme valeurs : 
        //64, 20, 48, 76
        //0 , 1 , 2 , 3
        //74, 84, 31, 47
        //Puis retourner la valeur qui se trouve à la 1ère ligne et 2ème colonne de ce nouveau tableau
        //(rappel, 1ère ligne = ligne 0; 1ère colonne = colonne 0)
        public int RecuperationValeurDoubleTableau1()
        {
            //-----Votre code ici --------    
            



            return 9999;
            //----------------------------
        }

        //Créer un double tableau de "int" possédant 3 lignes et 4 colonnes, avec comme valeurs : 
        //64, 20, 48, 76
        //0 , 1 , 2 , 3
        //74, 84, 31, 47
        //Modifier la valeur qui se situe à la 2ème ligne et 3ème colonne par 9646
        //Puis retourner la valeur qui se situe à la 2ème ligne et 3ème colonne
        public int RecuperationValeurDoubleTableau2()
        {
            //-----Votre code ici --------    
            



            return 9999;
            //----------------------------
        }

        /*          Cas particulier de doubles tableaux -> Jagged Arrays
        *    ------------------------------------------------------------------  
        *
        * Dans les exemples précédents, lorsqu'on créait un tableau 2D, chaque ligne devait avoir la même taille
        * 
        * En C#, il existe une variante de tableau 2D appelé "Jagged Arrays" qui permet, au sein du même tableau, d'avoir des lignes de tailles différentes :
        * 
        * int[][] jagged_array = new int[3][]; <- on indique le nombre de ligne qu'il y aura, mais pas leur taille, ce sera définit par après !
        *
        * jagged_array[0] = new int[] {1, 3, 5, 7, 9};
        * jagged_array[1] = new int[] {0, 2, 4, 6};
        * jagged_array[2] = new int[] {11, 22};
        * 
        * ce qui peut être représenté par :
        * |1  |3  |5 |7 |9 |
        * |0  |2  |4 |6 |
        * |11 |22 |   
        * 
        * L'avantage de cette variante, c'est que l'on peut copier un tableau à une dimension directement dans le tableau à 2 dimensions (et ça, de plusieurs façons)
        * 
        * int[] tab1 = {0, 1, 2, 3};
        * int[] tab2 = {4, 5, 6};
        * int[] tab3 = {7, 8};
        * 
        * int[][] jagged_array1 = { new int[] { 0, 1, 2, 3 }, tab1, new int[] { 8, 9, 10, 11 } };
        * 
        * int[][] jagged_array2 = {tab1, tab2, tab3};
        * 
        * int[][] jagged_array3 = new int[3][];
        * jagged_array3[0] = new int[] { 0, 1, 2 };
        * jagged_array3[1] = tab2;
        * jagged_array3[2] = tab3; 
        * 
        * Cette variante possède ses avantages, mais a aussi des inconvénients...
        * Vu que chaque ligne possède une taille différente, lorsqu'on parcourt chaque ligne, il faut faire attention à ne pas faire de dépassement de tableau !
        */

        //Créer un "Jagged" tableau à 2 dimensions de type "int" possédant 3 lignes, avec comme valeurs :
        //64, 20, 48, 76
        //0 , 1 , 2
        //74, 84, 31, 47, 452
        //remplacer la 1ère ligne entière par les valeurs de "tableau_defaut"
        //Puis retourner la valeur qui se situe à la 1ère ligne et 4ème colonne du tableau à 2 dimensions
        public int RecuperationValeurDoubleTableau3(int[] tableau_defaut)
        {
            //-----Votre code ici --------    
            





            return 9999;
            //----------------------------
        }

        //Créer un "Jagged" tableau à 2 dimensions de type "int" possédant 3 lignes, avec comme valeurs :
        //64, 20, 48, 76
        //0 , 1 , 2
        //74, 84, 31, 47, 452
        //Créer une variable qui va contenir la somme de toutes les valeurs contenue dans le tableau (case 1 + case 2 + case 3 + case 4 + ...)
        //BONUS : le faire via une boucle imbriquée de votre choix (rappel, pour avoir la taille d'une ligne : tableau[indice].Length)
        //Puis retourner cette somme
        public int RecuperationValeurDoubleTableau4()
        {
            //-----Votre code ici -------- 
            





            return 9999;
            //----------------------------
        }

        //Créer un "Jagged" tableau à 2 dimensions de type "int" possédant 3 lignes, avec comme valeurs : 
        //64, 20, 48, 76
        //0 , 1 , 2
        //74, 84, 31, 47, 452
        //Puis retourner la dernière ligne du tableau
        public int[] RecuperationValeurDoubleTableau5()
        {
            //-----Votre code ici --------






            return new int[5];
            //----------------------------
        }
    }
}
