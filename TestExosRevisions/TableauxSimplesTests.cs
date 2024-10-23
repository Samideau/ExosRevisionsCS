using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExosRevision;

namespace TestExosRevisions
{
    [TestClass]
    public class TableauxSimplesTests
    {
        private readonly TableauxSimplesRevisions tab_rev = new TableauxSimplesRevisions();

        [TestMethod]
        public void TestCreationTableau() 
        {
            int[] real_values = tab_rev.CreationTableau();
            Assert.AreEqual(45, real_values[0], "La valeur contenue à l'indice 0 du tableau que la fonction renvoie n'est pas correcte !");
            Assert.AreEqual(21, real_values[1], "La valeur contenue à l'indice 1 du tableau que la fonction renvoie n'est pas correcte !");
            Assert.AreEqual(36, real_values[2], "La valeur contenue à l'indice 2 du tableau que la fonction renvoie n'est pas correcte !");
            Assert.AreEqual(95, real_values[3], "La valeur contenue à l'indice 3 du tableau que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestCopyTableauParUnAutreCas1()
        {
            //Init Variables
            int[] tab = { 0, 1, 2, 3 };

            int[] real_values = tab_rev.CopyTableau(tab);
            Assert.AreEqual(tab[0], real_values[0], "La valeur contenue à l'indice 0 du tableau que la fonction renvoie n'est pas correcte !");
            Assert.AreEqual(tab[1], real_values[1], "La valeur contenue à l'indice 1 du tableau que la fonction renvoie n'est pas correcte !");
            Assert.AreEqual(tab[2], real_values[2], "La valeur contenue à l'indice 2 du tableau que la fonction renvoie n'est pas correcte !");
            Assert.AreEqual(tab[3], real_values[3], "La valeur contenue à l'indice 3 du tableau que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestCopyTableauParUnAutreCas2()
        {
            //Init Variables
            int[] tab = { 520, 11, 25, -3952};

            int[] real_values = tab_rev.CopyTableau(tab);
            Assert.AreEqual(tab[0], real_values[0], "La valeur contenue à l'indice 0 du tableau que la fonction renvoie n'est pas correcte !");
            Assert.AreEqual(tab[1], real_values[1], "La valeur contenue à l'indice 1 du tableau que la fonction renvoie n'est pas correcte !");
            Assert.AreEqual(tab[2], real_values[2], "La valeur contenue à l'indice 2 du tableau que la fonction renvoie n'est pas correcte !");
            Assert.AreEqual(tab[3], real_values[3], "La valeur contenue à l'indice 3 du tableau que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestCopyTableauParUnAutreCas3()
        {
            //Init Variables
            int[] tab = { -10, -951, -4102, -9662 };

            int[] real_values = tab_rev.CopyTableau(tab);
            Assert.AreEqual(tab[0], real_values[0], "La valeur contenue à l'indice 0 du tableau que la fonction renvoie n'est pas correcte !");
            Assert.AreEqual(tab[1], real_values[1], "La valeur contenue à l'indice 1 du tableau que la fonction renvoie n'est pas correcte !");
            Assert.AreEqual(tab[2], real_values[2], "La valeur contenue à l'indice 2 du tableau que la fonction renvoie n'est pas correcte !");
            Assert.AreEqual(tab[3], real_values[3], "La valeur contenue à l'indice 3 du tableau que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestRecuperationValeurTableau1()
        {
            int real_values = tab_rev.RecuperationValeurTableau1();
            Assert.AreEqual(48, real_values, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestRecuperationValeurTableau2()
        {
            int real_values = tab_rev.RecuperationValeurTableau2();
            Assert.AreEqual(9645, real_values, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestRecuperationValeurTableau3Cas1()
        {
            //Init Variables
            int[] tab = { 0, 1, 2, 5 };

            int real_values = tab_rev.RecuperationValeurTableau3(tab);
            Assert.AreEqual(0, real_values, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestRecuperationValeurTableau3Cas2()
        {
            //Init Variables
            int[] tab = { -10, -951, -4102, -9662 };

            int real_values = tab_rev.RecuperationValeurTableau3(tab);
            Assert.AreEqual(-10, real_values, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestRecuperationValeurTableau3Cas3()
        {
            //Init Variables
            int[] tab = { 1540, -951, -4102, -9662 };

            int real_values = tab_rev.RecuperationValeurTableau3(tab);
            Assert.AreEqual(1540, real_values, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestRecuperationValeurTableau4()
        {
            int real_values = tab_rev.RecuperationValeurTableau4();
            Assert.AreEqual(64 + 20 + 48 + 76, real_values, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestRecuperationValeurTableau5Cas1()
        {
            //Init Variables
            int[] tab = { 1540, -951, -5, -9662 };

            int real_values = tab_rev.RecuperationValeurTableau5(tab);
            Assert.AreEqual(tab[2] * 64, real_values, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestRecuperationValeurTableau5Cas2()
        {
            //Init Variables
            int[] tab = { 1540, -951, 10, -9662 };

            int real_values = tab_rev.RecuperationValeurTableau5(tab);
            Assert.AreEqual(tab[2] * 64, real_values, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestRecuperationValeurTableau5Cas3()
        {
            //Init Variables
            int[] tab = { 1540, -951, 17, -9662 };

            int real_values = tab_rev.RecuperationValeurTableau5(tab);
            Assert.AreEqual(tab[2] * 64, real_values, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestRecuperationValeurTableau5Cas4()
        {
            //Init Variables
            int[] tab = { 1540, -951, 0, -9662 };

            int real_values = tab_rev.RecuperationValeurTableau5(tab);
            Assert.AreEqual(tab[2] * 64, real_values, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestCreationModificationTableauCas1()
        {
            //Init Variables
            int[] tab = { 1540, 10, 0, 5 };

            int[] real_values = tab_rev.CreationModificationTableau(tab);
            Assert.AreEqual(64 + tab[0], real_values[0], "La valeur contenue à l'indice 0 du tableau que la fonction renvoie n'est pas correcte !");
            Assert.AreEqual(39 - tab[1], real_values[1], "La valeur contenue à l'indice 1 du tableau que la fonction renvoie n'est pas correcte !");
            Assert.AreEqual(48 * tab[2], real_values[2], "La valeur contenue à l'indice 2 du tableau que la fonction renvoie n'est pas correcte !");
            Assert.AreEqual(75 / tab[3], real_values[3], "La valeur contenue à l'indice 3 du tableau que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestCreationModificationTableauCas2()
        {
            //Init Variables
            int[] tab = { -1540, 951, 1, 75 };

            int[] real_values = tab_rev.CreationModificationTableau(tab);
            Assert.AreEqual(64 + tab[0], real_values[0], "La valeur contenue à l'indice 0 du tableau que la fonction renvoie n'est pas correcte !");
            Assert.AreEqual(39 - tab[1], real_values[1], "La valeur contenue à l'indice 1 du tableau que la fonction renvoie n'est pas correcte !");
            Assert.AreEqual(48 * tab[2], real_values[2], "La valeur contenue à l'indice 2 du tableau que la fonction renvoie n'est pas correcte !");
            Assert.AreEqual(75 / tab[3], real_values[3], "La valeur contenue à l'indice 3 du tableau que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestCreationModificationTableauCas3()
        {
            //Init Variables
            int[] tab = { -40, -951, 41, 1 };

            int[] real_values = tab_rev.CreationModificationTableau(tab);
            Assert.AreEqual(64 + tab[0], real_values[0], "La valeur contenue à l'indice 0 du tableau que la fonction renvoie n'est pas correcte !");
            Assert.AreEqual(39 - tab[1], real_values[1], "La valeur contenue à l'indice 1 du tableau que la fonction renvoie n'est pas correcte !");
            Assert.AreEqual(48 * tab[2], real_values[2], "La valeur contenue à l'indice 2 du tableau que la fonction renvoie n'est pas correcte !");
            Assert.AreEqual(75 / tab[3], real_values[3], "La valeur contenue à l'indice 3 du tableau que la fonction renvoie n'est pas correcte !");
        }

    }
}
