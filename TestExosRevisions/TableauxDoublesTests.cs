using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExosRevision;

namespace TestExosRevisions
{
    [TestClass]
    public class TableauxDoublesTests
    {
        private readonly TableauxDoublesRevisions tab_doub_rev = new TableauxDoublesRevisions();

        [TestMethod]
        public void TestRecuperationValeurDoubleTableau1()
        {
            int real_values = tab_doub_rev.RecuperationValeurDoubleTableau1();
            Assert.AreEqual(20, real_values, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestRecuperationValeurDoubleTableau2()
        {
            int real_values = tab_doub_rev.RecuperationValeurDoubleTableau2();
            Assert.AreEqual(9646, real_values, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestRecuperationValeurDoubleTableau3Cas1()
        {
            //Init Variables
            int[] tab = { 0, 1, 2, 3 };

            int real_values = tab_doub_rev.RecuperationValeurDoubleTableau3(tab);
            Assert.AreEqual(3, real_values, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestRecuperationValeurDoubleTableau3Cas2()
        {
            //Init Variables
            int[] tab = { 90, 99999, 56, 48413, 894, 81651, 14152, 123465 };

            int real_values = tab_doub_rev.RecuperationValeurDoubleTableau3(tab);
            Assert.AreEqual(48413, real_values, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestRecuperationValeurDoubleTableau3Cas3()
        {
            //Init Variables
            int[] tab = { -10, -451, -142, -84853, -4, -9345 };

            int real_values = tab_doub_rev.RecuperationValeurDoubleTableau3(tab);
            Assert.AreEqual(-84853, real_values, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestRecuperationValeurDoubleTableau3Cas4()
        {
            //Init Variables
            int[] tab = { 9, 8, 7, 6, 5 };

            int real_values = tab_doub_rev.RecuperationValeurDoubleTableau3(tab);
            Assert.AreEqual(6, real_values, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestRecuperationValeurDoubleTableau4()
        {
            int real_values = tab_doub_rev.RecuperationValeurDoubleTableau4();
            Assert.AreEqual(899, real_values, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestRecuperationValeurDoubleTableau5()
        {
            int[] real_values = tab_doub_rev.RecuperationValeurDoubleTableau5();
            Assert.AreEqual(74, real_values[0], "La valeur contenue à l'indice 0 du tableau que la fonction renvoie n'est pas correcte !");
            Assert.AreEqual(84, real_values[1], "La valeur contenue à l'indice 1 du tableau que la fonction renvoie n'est pas correcte !");
            Assert.AreEqual(31, real_values[2], "La valeur contenue à l'indice 2 du tableau que la fonction renvoie n'est pas correcte !");
            Assert.AreEqual(47, real_values[3], "La valeur contenue à l'indice 3 du tableau que la fonction renvoie n'est pas correcte !");
            Assert.AreEqual(452, real_values[4], "La valeur contenue à l'indice 4 du tableau que la fonction renvoie n'est pas correcte !");
        }
    }
}
