using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13RPS
{
    class RoshamboApp
    {
        public List<Player> Players = new List<Player>();
        public string[] RightOn = { "SICK!!!!", "LEGALIZE RANCH!!", "DUUUUUUDE! nice.", "WHAAAAAAM!", "GNARLY!", "DOPE AS ALL HELL!!!", "RADICAL!" };
        public string[] Bummer = { "Maybe next time homie", "duuuuuude that sucks", "commit or eat shit my guy", "Daaaaawww man!", "If you need help fixing the game, I take cash." };

        public void PlayRPS()
        {
            Random r = new Random();
            //setup
            Console.WriteLine("Welcome to Roshambo EXTREME!\n" +
                "\nWhat's your name? HURRY GO!");
            string uName = Console.ReadLine();
            User user = new User(uName);
            Player opponent;
            Players.Add(user);

            int choice = 0;
            Console.WriteLine($"\nWhat up {user.Name}! Who would you like to play?!??!!\n" +
                $"\n1)  Ranbo" +
                $"\n2)  RockMan" +
                $"\nChoose 1 or 2:");
            Validator.IsInRangeIndex(Console.ReadLine(), 1, 2, out choice);
            if(choice == 0)
            {
                opponent = new Ranbo();
            }
            else
            {
                opponent = new RockMan();
            }
            Players.Add(opponent);

            while (true)
            {
                //generate win or loss along with encouragement.

                int noiceNum = r.Next(0, (RightOn.Length - 1));
                int bumNum = r.Next(0, (Bummer.Length - 1));
                string noice = RightOn[noiceNum];
                string doh = Bummer[bumNum];

                string uChoice = user.generateRoshambo();
                string oChoice = opponent.generateRoshambo();
                int match = WhoWon(uChoice, oChoice);

                Console.WriteLine($"\n{user.Name} picks {uChoice}!" +
                    $"\n{opponent.Name} picks {oChoice}!\n");

                switch(match)
                {
                    case 0:
                        Console.WriteLine("It's a tie!");
                        break;
                    case 1:
                        Console.WriteLine($"You win! {noice}");
                        user.Wins++;
                        break;
                    case 2:
                        Console.WriteLine($"{opponent.Name} wins...{doh}");
                        user.Losses++;
                        break;
                    default:
                        Console.WriteLine("EXCRUCIATINGLY TERRIBLE FAILURE");
                        break;
                }
                Console.WriteLine("\nDo you want to play again? (Y/N)");
                if(Validator.YayOrNay(Console.ReadLine().ToUpper()))
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine($"You won {user.Wins} times and lost {user.Losses} times.");
            Console.WriteLine("Later!");




        }

        public int WhoWon (string str1, string str2)
        {
            if(str1 == str2)
            {
                return 0;
            }
            else if (str1 == "Scissors" && str2 == "Paper")
            {
                return 1;
            }
            else if (str1 == "Paper" && str2 == "Rock")
            {
                return 1;
            }
            else if (str1 == "Rock" && str2 == "Scissors")
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
    }
}
