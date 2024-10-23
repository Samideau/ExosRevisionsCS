using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExosRevision;

namespace TestExosRevisions
{
    [TestClass]
    public class ConditionsAvanceesTests
    {
        private readonly ConditionsAvanceesRevisions cond_av_rev = new ConditionsAvanceesRevisions();

        [TestMethod]
        public void TestConditionImbriqueeCas1()
        {
            //Init Variables
            int valeur_utilisateur = 10;

            int real_value = cond_av_rev.ConditionImbriquee(valeur_utilisateur);
            Assert.AreEqual(50, real_value, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestConditionImbriqueeCas2()
        {
            //Init Variables
            int valeur_utilisateur = 100;

            int real_value = cond_av_rev.ConditionImbriquee(valeur_utilisateur);
            Assert.AreEqual(25, real_value, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestConditionImbriqueeCas3()
        {
            //Init Variables
            int valeur_utilisateur = 0;

            int real_value = cond_av_rev.ConditionImbriquee(valeur_utilisateur);
            Assert.AreEqual(0, real_value, "La valeur que la fonction renvoie n'est pas correcte !");
        }
        //--------------------------
        [TestMethod]
        public void TestDoubleCondition1Cas1()
        {
            //Init Variables
            int valeur_utilisateur = 5;

            int real_value = cond_av_rev.DoubleCondition1(valeur_utilisateur);
            Assert.AreEqual(25, real_value, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestDoubleCondition1Cas2()
        {
            //Init Variables
            int valeur_utilisateur = 1000;

            int real_value = cond_av_rev.DoubleCondition1(valeur_utilisateur);
            Assert.AreEqual(0, real_value, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestDoubleCondition1Cas3()
        {
            //Init Variables
            int valeur_utilisateur = -10;

            int real_value = cond_av_rev.DoubleCondition1(valeur_utilisateur);
            Assert.AreEqual(0, real_value, "La valeur que la fonction renvoie n'est pas correcte !");
        }
        //--------------------------
        [TestMethod]
        public void TestDoubleCondition2Cas1()
        {
            //Init Variables
            int valeur_utilisateur = 5;

            int real_value = cond_av_rev.DoubleCondition2(valeur_utilisateur);
            Assert.AreEqual(25, real_value, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestDoubleCondition2Cas2()
        {
            //Init Variables
            int valeur_utilisateur = -1000;

            int real_value = cond_av_rev.DoubleCondition2(valeur_utilisateur);
            Assert.AreEqual(25, real_value, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestDoubleCondition2Cas3()
        {
            //Init Variables
            int valeur_utilisateur = 0;

            int real_value = cond_av_rev.DoubleCondition2(valeur_utilisateur);
            Assert.AreEqual(0, real_value, "La valeur que la fonction renvoie n'est pas correcte !");
        }
        //--------------------------
        [TestMethod]
        public void TestConditionSinonSuppCas1()
        {
            //Init Variables
            int valeur_utilisateur = 5;

            int real_value = cond_av_rev.ConditionSinonSupp(valeur_utilisateur);
            Assert.AreEqual(25, real_value, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestConditionSinonSuppCas2()
        {
            //Init Variables
            int valeur_utilisateur = -5;

            int real_value = cond_av_rev.ConditionSinonSupp(valeur_utilisateur);
            Assert.AreEqual(50, real_value, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestConditionSinonSuppCas3()
        {
            //Init Variables
            int valeur_utilisateur = -1000;

            int real_value = cond_av_rev.ConditionSinonSupp(valeur_utilisateur);
            Assert.AreEqual(0, real_value, "La valeur que la fonction renvoie n'est pas correcte !");
        }
        //--------------------------
        [TestMethod]
        public void TestConditionTotaleCas1()
        {
            //Init Variables
            int valeur_utilisateur = 5;

            int real_value = cond_av_rev.ConditionTotale(valeur_utilisateur);
            Assert.AreEqual(25, real_value, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestConditionTotaleCas2()
        {
            //Init Variables
            int valeur_utilisateur = 15;

            int real_value = cond_av_rev.ConditionTotale(valeur_utilisateur);
            Assert.AreEqual(50, real_value, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestConditionTotaleCas3()
        {
            //Init Variables
            int valeur_utilisateur = 1000;

            int real_value = cond_av_rev.ConditionTotale(valeur_utilisateur);
            Assert.AreEqual(0, real_value, "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestConditionTotaleCas4()
        {
            //Init Variables
            int valeur_utilisateur = -1000;

            int real_value = cond_av_rev.ConditionTotale(valeur_utilisateur);
            Assert.AreEqual(0, real_value, "La valeur que la fonction renvoie n'est pas correcte !");
        }
    }
}
