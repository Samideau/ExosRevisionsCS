using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExosRevision;

namespace TestExosRevisions
{
    [TestClass]
    public class OutputTests
    {
        private readonly OutputRevisions out_rev = new OutputRevisions();

        [TestMethod]
        public void TestWriteLineBase()
        {
            //Init Variables
            StringWriter console_output = new StringWriter();
            Console.SetOut(console_output);

            out_rev.WriteLineBase();
            string console_output_text = console_output.ToString();

            Assert.AreEqual("Bien le bonjour à toi bel(le) homme (ou femme), que voulez-vous faire ?", console_output_text.Substring(0, console_output_text.Length - 2),
                "Le texte encodé dans la console n'est pas valide !");
        }

        [TestMethod]
        public void TestWriteLineSingle()
        {
            //Init Variables
            string string_utilisateur = "Guillaume";
            StringWriter console_output = new StringWriter();
            Console.SetOut(console_output);

            out_rev.WriteLineSingle(string_utilisateur);
            string console_output_text = console_output.ToString();

            Assert.AreEqual($"Bonjour {string_utilisateur}, que voulez-vous faire ?", console_output_text.Substring(0, console_output_text.Length-2),
                "Le texte encodé dans la console n'est pas valide !");
        }

        [TestMethod]
        public void TestWriteLineMultiple()
        {
            //Init Variables
            string string_utilisateur = "Catherine";
            float valeur_argent = 15.00f;
            double valeur_dette = 9999.9999;
            int valeur_temps_restant = 4;
            StringWriter console_output = new StringWriter();
            Console.SetOut(console_output);

            out_rev.WriteLineMultiple(string_utilisateur, valeur_argent, valeur_dette, valeur_temps_restant);
            string console_output_text = console_output.ToString();

            Assert.AreEqual($"Bonjour {string_utilisateur}, il vous reste {valeur_argent}€ sur votre compte en banque et votre dette s'élève à {valeur_dette}€. Il vous reste {valeur_temps_restant} jours pour rembourser vos dettes !", 
                console_output_text.Substring(0, console_output_text.Length - 2), 
                "Le texte encodé dans la console n'est pas valide !");
        }
    }
}
