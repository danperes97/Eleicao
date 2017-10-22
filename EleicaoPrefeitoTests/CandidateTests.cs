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
    public class CandidateTests
    {
        public Party party = new Party("Partido dos partidos", "PP");

        [TestMethod()]
        public void CandidateNameTest()
        {
            var candidate = new Candidate("Gula", 13, party);

            Assert.AreEqual("Gula", candidate.Name);
        }

        [TestMethod()]
        public void CandidateNumberTest()
        {
            var candidate = new Candidate("Gula", 13, party);

            Assert.AreEqual(13, candidate.Number);
        }

        [TestMethod()]
        public void CandidatePartyTest()
        {
            var candidate = new Candidate("Gula", 13, party);

            Assert.AreEqual(party.Name, candidate.Party.Name);
            Assert.AreEqual(party.Initials, candidate.Party.Initials);
        }

        [TestMethod()]
        public void CandidateInformationTest()
        {
            var candidate = new Candidate("Gula", 13, party);

            var candidate_informations = "Name: Gula\n" +
                                          "Number: 13\n" +
                                          "Party Name: Partido dos partidos\n" +
                                          "Party Initials: PP\n";

            Assert.AreEqual(candidate_informations, candidate.Informations());
        }

        [TestMethod()]
        public void CandidateVotesTest()
        {
            var candidate = new Candidate("Gula", 13, party);
            candidate.AddVote();

            Assert.AreEqual(candidate.Votes, 1);
        }
    }
}