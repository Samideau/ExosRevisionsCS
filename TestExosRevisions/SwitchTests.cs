using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExosRevision;

namespace TestExosRevisions
{
    [TestClass]
    public class SwitchTests
    {
        private readonly SwitchRevisions switch_rev = new SwitchRevisions();

        [TestMethod]
        public void TestSwitchJanvier() 
        {
            //Init Variables
            int valeur_mois = 1;

            string real_value = switch_rev.Switch(valeur_mois);
            Assert.AreEqual("janvier", real_value.ToLower(), "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestSwitchFevrier()
        {
            //Init Variables
            int valeur_mois = 2;

            string real_value = switch_rev.Switch(valeur_mois);
            Assert.AreEqual("février", real_value.ToLower(), "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestSwitchMars()
        {
            //Init Variables
            int valeur_mois = 3;

            string real_value = switch_rev.Switch(valeur_mois);
            Assert.AreEqual("mars", real_value.ToLower(), "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestSwitchAvril()
        {
            //Init Variables
            int valeur_mois = 4;

            string real_value = switch_rev.Switch(valeur_mois);
            Assert.AreEqual("avril", real_value.ToLower(), "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestSwitchMai()
        {
            //Init Variables
            int valeur_mois = 5;

            string real_value = switch_rev.Switch(valeur_mois);
            Assert.AreEqual("mai", real_value.ToLower(), "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestSwitchJuin()
        {
            //Init Variables
            int valeur_mois = 6;

            string real_value = switch_rev.Switch(valeur_mois);
            Assert.AreEqual("juin", real_value.ToLower(), "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestSwitchJuillet()
        {
            //Init Variables
            int valeur_mois = 7;

            string real_value = switch_rev.Switch(valeur_mois);
            Assert.AreEqual("juillet", real_value.ToLower(), "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestSwitchAout()
        {
            //Init Variables
            int valeur_mois = 8;

            string real_value = switch_rev.Switch(valeur_mois);
            Assert.AreEqual("août", real_value.ToLower(), "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestSwitchSeptembre()
        {
            //Init Variables
            int valeur_mois = 9;

            string real_value = switch_rev.Switch(valeur_mois);
            Assert.AreEqual("septembre", real_value.ToLower(), "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestSwitchOctobre()
        {
            //Init Variables
            int valeur_mois = 10;

            string real_value = switch_rev.Switch(valeur_mois);
            Assert.AreEqual("octobre", real_value.ToLower(), "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestSwitchNovembre()
        {
            //Init Variables
            int valeur_mois = 11;

            string real_value = switch_rev.Switch(valeur_mois);
            Assert.AreEqual("novembre", real_value.ToLower(), "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestSwitchDecembre()
        {
            //Init Variables
            int valeur_mois = 12;

            string real_value = switch_rev.Switch(valeur_mois);
            Assert.AreEqual("décembre", real_value.ToLower(), "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestSwitchErreurNegative()
        {
            //Init Variables
            int valeur_mois = -9999;

            string real_value = switch_rev.Switch(valeur_mois);
            Assert.AreEqual("erreur", real_value.ToLower(), "La valeur que la fonction renvoie n'est pas correcte !");
        }

        [TestMethod]
        public void TestSwitchErreurPositive()
        {
            //Init Variables
            int valeur_mois = 9999;

            string real_value = switch_rev.Switch(valeur_mois);
            Assert.AreEqual("erreur", real_value.ToLower(), "La valeur que la fonction renvoie n'est pas correcte !");
        }
    }
}
