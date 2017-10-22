using Microsoft.VisualStudio.TestTools.UnitTesting;
using EleicaoPrefeito;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleicaoPrefeito.Tests
{
    [TestClass()]
    public class PartyTests
    {
        public Party party = new Party("Partido dos partidos", "PP");

        [TestMethod()]
        public void PartyNameTest()
        {
            Assert.AreEqual("Partido dos partidos", party.Name);
        }

        [TestMethod()]
        public void PartyInitialsTest()
        {
            Assert.AreEqual("PP", party.Initials);
        }
    }
}