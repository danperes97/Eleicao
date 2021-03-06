﻿using System;
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

        public string Name { get; set; }
        public Int32 Number { get; set; }
        public Int32 Votes { get; set; }
        public Party Party { get; set; }

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
