using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13RPS
{
    public abstract class Player
    {
        public string Rock { get; } = "Rock";
        public string Paper { get; } = "Paper";
        public string Scissors { get; } = "Scissors";

        public string Name { get; set; }
        public abstract string generateRoshambo();

    }
}
