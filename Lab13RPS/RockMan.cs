using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13RPS
{
    class RockMan : Player
    {
        public RockMan()
        {
            Name = "RockMan";
        }

        public override string generateRoshambo()
        {
            return Rock;
        }
    }
}
