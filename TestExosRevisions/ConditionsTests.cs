using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExosRevision;

namespace TestExosRevisions
{
    [TestClass]
    public class ConditionsTests
    {
        private readonly ConditionsRevisions cond_rev = new ConditionsRevisions();

        [TestMethod]
        public void TestCondition1ALess()
        {
            //Init Variables
            int valeur_a = 15;
            int valeur_b = 35;

            int real_value = cond_rev.Condition1(valeur_a, valeur_b);
            Assert.AreEqual(valeur_b, real_value, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestCondition1AEqual()
        {
            //Init Variables
            int valeur_a = 35;
            int valeur_b = 35;

            int real_value = cond_rev.Condition1(valeur_a, valeur_b);
            Assert.AreEqual(valeur_b, real_value, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestCondition1AGreater()
        {
            //Init Variables
            int valeur_a = 60;
            int valeur_b = 35;

            int real_value = cond_rev.Condition1(valeur_a, valeur_b);
            Assert.AreEqual(valeur_a, real_value, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestCondition2ALess()
        {
            //Init Variables
            int valeur_a = 15;
            int valeur_b = 35;

            int real_value = cond_rev.Condition2(valeur_a, valeur_b);
            Assert.AreEqual(valeur_a, real_value, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestCondition2AEqual()
        {
            //Init Variables
            int valeur_a = 35;
            int valeur_b = 35;

            int real_value = cond_rev.Condition2(valeur_a, valeur_b);
            Assert.AreEqual(valeur_a, real_value, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestCondition2AGreater()
        {
            //Init Variables
            int valeur_a = 60;
            int valeur_b = 35;

            int real_value = cond_rev.Condition2(valeur_a, valeur_b);
            Assert.AreEqual(valeur_b, real_value, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestCondition3ALess()
        {
            //Init Variables
            int valeur_a = 15;
            int valeur_b = 35;

            int real_value = cond_rev.Condition3(valeur_a, valeur_b);
            Assert.AreEqual(valeur_b, real_value, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestCondition3AEqual()
        {
            //Init Variables
            int valeur_a = 35;
            int valeur_b = 35;

            int real_value = cond_rev.Condition3(valeur_a, valeur_b);
            Assert.AreEqual(valeur_a, real_value, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestCondition3AGreater()
        {
            //Init Variables
            int valeur_a = 60;
            int valeur_b = 35;

            int real_value = cond_rev.Condition3(valeur_a, valeur_b);
            Assert.AreEqual(valeur_b, real_value, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestCondition4ALess()
        {
            //Init Variables
            int valeur_a = 15;
            int valeur_b = 35;

            int real_value = cond_rev.Condition4(valeur_a, valeur_b);
            Assert.AreEqual(valeur_a + valeur_b, real_value, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestCondition4AEqual()
        {
            //Init Variables
            int valeur_a = 35;
            int valeur_b = 35;

            int real_value = cond_rev.Condition4(valeur_a, valeur_b);
            Assert.AreEqual(valeur_a - valeur_b, real_value, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestCondition4AGreater()
        {
            //Init Variables
            int valeur_a = 60;
            int valeur_b = 35;

            int real_value = cond_rev.Condition4(valeur_a, valeur_b);
            Assert.AreEqual(valeur_a + valeur_b, real_value, "La valeur que la fonction renvoie n'est pas correcte !");
        }
    }
}
