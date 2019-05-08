using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13RPS
{
    class User : Player
    {
        public int Wins { get; set; } = 0;
        public int Losses { get; set; } = 0;

        public User(string name)
        {
            Name = name;
        }

        public override string generateRoshambo()
        {
            string[] RPS = { Rock, Paper, Scissors };
            Console.WriteLine("\nWhat would you like to throw?\n" +
                $"\n1)  {Rock}" +
                $"\n2)  {Paper}" +
                $"\n3)  {Scissors}");
            int choice = 0;
            Validator.IsInRangeIndex(Console.ReadLine(), 1, 3, out choice);
            return RPS[choice];
        }
    }
}
