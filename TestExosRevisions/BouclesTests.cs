using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExosRevision;

namespace TestExosRevisions
{
    [TestClass]
    public class BouclesTests
    {
        private readonly BouclesRevisions loop_rev = new BouclesRevisions();

        [TestMethod]
        public void TestBoucleForNormal()
        {
            //Init Variables
            int valeur_a = 0;

            int real_value = loop_rev.BoucleFor(valeur_a);
            Assert.AreEqual(10, real_value, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestBoucleForSkip()
        {
            //Init Variables
            int valeur_a = 15;

            int real_value = loop_rev.BoucleFor(valeur_a);
            Assert.AreEqual(valeur_a, real_value, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestBoucleWhileNormal()
        {
            //Init Variables
            int valeur_a = 10;

            int real_value = loop_rev.BoucleWhile(valeur_a);
            Assert.AreEqual(0, real_value, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestBoucleWhileSkip()
        {
            //Init Variables
            int valeur_a = -10;

            int real_value = loop_rev.BoucleWhile(valeur_a);
            Assert.AreEqual(valeur_a, real_value, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestBoucleDoWhileNormal()
        {
            //Init Variables
            int valeur_a = 0;

            int real_value = loop_rev.BoucleDoWhile(valeur_a);
            Assert.AreEqual(10, real_value, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestBoucleDoWhileSpecial()
        {
            //Init Variables
            int valeur_a = -1;

            int real_value = loop_rev.BoucleDoWhile(valeur_a);
            Assert.AreEqual(11, real_value, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestBoucleDoWhileSkip()
        {
            //Init Variables
            int valeur_a = 60;

            int real_value = loop_rev.BoucleDoWhile(valeur_a);
            Assert.AreEqual(valeur_a + 2, real_value, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestBoucleDoWhileSpecial1()
        {
            //Init Variables
            int valeur_a = 10;

            int real_value = loop_rev.BoucleDoWhileSpecial(valeur_a);
            Assert.AreEqual(valeur_a + 2, real_value, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestBoucleDoWhileSpecial2()
        {
            //Init Variables
            int valeur_a = 60;

            int real_value = loop_rev.BoucleDoWhileSpecial(valeur_a);
            Assert.AreEqual(valeur_a + 2, real_value, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestBoucleConditionNormal()
        {
            //Init Variables
            int valeur_a = 0;
            int valeur_b = 60;

            int real_value = loop_rev.ComboBoucleCondition(valeur_a, valeur_b);
            Assert.AreEqual(valeur_b - 5, real_value, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestBoucleConditionSkip()
        {
            //Init Variables
            int valeur_a = 100;
            int valeur_b = 60;

            int real_value = loop_rev.ComboBoucleCondition(valeur_a, valeur_b);
            Assert.AreEqual(valeur_b, real_value, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestBoucleBreakNormal()
        {
            //Init Variables
            int valeur_a = 0;
            int valeur_b = 60;

            int real_value = loop_rev.BreakBoucle(valeur_a, valeur_b);
            Assert.AreEqual(40, real_value, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestBoucleBreakSkip()
        {
            //Init Variables
            int valeur_a = 0;
            int valeur_b = 10;

            int real_value = loop_rev.BreakBoucle(valeur_a, valeur_b);
            Assert.AreEqual(valeur_b-1, real_value, "La valeur que la fonction renvoie n'est pas correcte !");
        }
    }
}
