using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleicaoPrefeito
{
    public class Candidate
    {
        private string name;
        private Party party;
        private int number;
        private int votes;

        public string Name { get => name; set => name = value; }
        public int Number { get => number; set => number = value; }
        public int Votes { get => votes; }
        public Party Party { get => party; set => party = value; }

        public Candidate(string name, int number, Party party)
        {
            this.Name = name;
            this.number = number;
            this.Party = party;
            this.votes = 0;
        }

        public String Informations()
        {
            string candidate_informations;

            candidate_informations = "Name: " + this.Name + "\n";
            candidate_informations += "Number: " + this.Number + "\n";
            candidate_informations += "Party Name: " + this.Party.Name + "\n";
            candidate_informations += "Party Initials: " + this.Party.Initials + "\n";

            return candidate_informations;
        }

        public void AddVote()
        {
            this.votes++;
        }
    }
}
