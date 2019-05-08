using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13RPS
{
    class Ranbo : Player
    {
        public Ranbo()
        {
            Name = "Ranbo";
        }

        Random ran = new Random();

        public override string generateRoshambo()
        {
            int r = ran.Next(0, 3);
            string[] RPS = { Rock, Paper, Scissors };
            return RPS[r];
        }
    }
}
