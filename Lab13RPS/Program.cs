using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13RPS
{
    class Program
    {
        static void Main(string[] args)
        {
            RoshamboApp roshie = new RoshamboApp();
            roshie.PlayRPS();
            Console.ReadKey();
        }
    }
}
