using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleicaoPrefeito
{
    public class Party
    {
        private string name;
        private string initials;

        public Party(string name, string initials)
        {
            this.Name = name;
            this.Initials = initials;
        }

        public string Name { get => name; set => name = value; }
        public string Initials { get => initials; set => initials = value; }
    }
}
