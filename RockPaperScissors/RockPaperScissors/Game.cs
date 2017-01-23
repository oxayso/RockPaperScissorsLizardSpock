using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Game
    {
        public Player playerOne;
        public Player playerTwo;
        public Game()
        {

        }
        public void DisplayRules()
        {
            Console.WriteLine("Let's play a classic: Rock, Paper, Scissors. \n\nUnder one condition... \n-The game has since expanded & thus, has developed a new name: Rock, Paper, Scissors, Lizard, Spock... \n\nTHE RULES: \n\n-Scissors cuts Paper \n-Paper covers Rock \n-Rock crushes Lizard \n-Lizard poisons Spock \n-Spock smashes Scissors \n-Scissors decapitates Lizard \n-Lizard eats Paper \n-Paper disproves Spock \n-Spock vaporizes Rock \n(and as it always has...) \n-Rock crushes Scissors\n \n\nLET'S GO!\n\n");

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
        }
        public string PlayerMode()
        {
            Console.WriteLine("Please choose your opponent. \n\nA. Human VS. A.I \nB. Human VS. Human");
            string opponent = Console.ReadLine().ToUpper();
            return opponent;
        }

        public void PlayerChoice(string opponent)
        {
            switch (opponent)
            {
                case "A":
                    Console.WriteLine("\nThink you can you beat Artificial Intelligence? Think again!");
                    playerOne = new Human();
                    playerTwo = new AI();
                    break;
                case "B":
                    Console.WriteLine("\nLet's. Get. Ready. To... RUMBLE!");
                    playerOne = new Human();
                    playerTwo = new Human();
                    break;
                default:
                    break;
            }
        }

        public void DisplayBreakPoint()
        {
            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
        }

        //public string DetermineWinner()
        //{
        //    for (d = (5 + a - b) % 5)
        //    {
        //        if (d = 1 || decimal = 3 => a)
        //    {
        //        Console.WriteLine("WIN");
        //    }
        //    }
                 
        //}


        //public int GetComputerChoice()
        //{

        //}
        public void RunGame()
        {
            DisplayRules();
            string opponent = PlayerMode();
            PlayerChoice(opponent);
            DisplayBreakPoint();
            playerOne.GetPlayerName();
            playerTwo.GetPlayerName();
            playerOne.PrintPlayerName();
            playerTwo.PrintPlayerName();
            playerOne.GetHumanChoice();
            playerTwo.GetHumanChoice();           
        }
    }
}

    


