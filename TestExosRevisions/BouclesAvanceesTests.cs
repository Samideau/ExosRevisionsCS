using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExosRevision;

namespace TestExosRevisions
{
    [TestClass]
    public class BouclesAvanceesTests
    {
        [TestMethod]
        public void TestBoucleImbriquee()
        {
            //Init Variables
            string mot_special = "";
            BouclesAvanceesRevisions cond_av_rev = new BouclesAvanceesRevisions();


            string real_value = cond_av_rev.BoucleImbriquee(mot_special);
            Assert.AreEqual("ABBBABBBABBBABBBABBB", real_value, "La valeur que la fonction renvoie n'est pas correcte !");
        }
    }
}
