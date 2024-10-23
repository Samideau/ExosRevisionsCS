using ExosRevision;

namespace TestExosRevisions
{
    [TestClass]
    public class VariablesTests
    {
        private readonly VariablesRevisions var_rev = new VariablesRevisions();

        [TestMethod]
        public void TestAdditionPositive()
        {
            //Init Variables
            int valeur_a = 60;
            int valeur_b = 35;

            int real_value = var_rev.Addition(valeur_a, valeur_b);
            Assert.AreEqual(valeur_a + valeur_b, real_value, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestAdditionZero()
        {
            //Init Variables
            int valeur_a = -35;
            int valeur_b = 35;

            int real_value = var_rev.Addition(valeur_a, valeur_b);
            Assert.AreEqual(valeur_a + valeur_b, real_value, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestAdditionNegative()
        {
            //Init Variables
            int valeur_a = -60;
            int valeur_b = -35;

            int real_value = var_rev.Addition(valeur_a, valeur_b);
            Assert.AreEqual(valeur_a + valeur_b, real_value, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestSoustractionPositive()
        {
            //Init Variables
            int valeur_a = 60;
            int valeur_b = -35;

            int real_value = var_rev.Soustraction(valeur_a, valeur_b);
            Assert.AreEqual(valeur_a - valeur_b, real_value, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestSoustractionZero()
        {
            //Init Variables
            int valeur_a = 35;
            int valeur_b = 35;

            int real_value = var_rev.Soustraction(valeur_a, valeur_b);
            Assert.AreEqual(valeur_a - valeur_b, real_value, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestSoustractionNegative()
        {
            //Init Variables
            int valeur_a = -60;
            int valeur_b = 35;

            int real_value = var_rev.Soustraction(valeur_a, valeur_b);
            Assert.AreEqual(valeur_a - valeur_b, real_value, "La valeur que la fonction renvoie n'est pas correcte !");
        }


        [TestMethod]
        public void TestMultiplicationPositive()
        {
            //Init Variables
            int valeur_a = 60;
            int valeur_b = 35;

            float real_value = var_rev.Multiplication(valeur_a, valeur_b);
            Assert.AreEqual(valeur_a * valeur_b, real_value, 0.001f, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestMultiplicationZero()
        {
            //Init Variables
            int valeur_a = 60;
            int valeur_b = 0;

            float real_value = var_rev.Multiplication(valeur_a, valeur_b);
            Assert.AreEqual(valeur_a * valeur_b, real_value, 0.001f, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestMultiplicationNegative()
        {
            //Init Variables
            int valeur_a = 60;
            int valeur_b = -35;

            float real_value = var_rev.Multiplication(valeur_a, valeur_b);
            Assert.AreEqual(valeur_a * valeur_b, real_value, 0.001f, "La valeur que la fonction renvoie n'est pas correcte !");
        }


        [TestMethod]
        public void TestDivisionByOne()
        {
            //Init Variables
            int valeur_a = 60;
            int valeur_b = 1;

            float real_value = var_rev.Division(valeur_a, valeur_b);
            Assert.AreEqual(valeur_a / valeur_b, real_value, 0.001f, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestDivisionFloat()
        {
            //Init Variables
            int valeur_a = 60;
            int valeur_b = 35;

            float real_value = var_rev.Division(valeur_a, valeur_b);
            Assert.AreEqual(valeur_a / valeur_b, real_value, 0.001f, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestDivisionInteger()
        {
            //Init Variables
            int valeur_a = 60;
            int valeur_b = 60;

            float real_value = var_rev.Division(valeur_a, valeur_b);
            Assert.AreEqual(valeur_a / valeur_b, real_value, 0.001f, "La valeur que la fonction renvoie n'est pas correcte !");
        }

    }
}