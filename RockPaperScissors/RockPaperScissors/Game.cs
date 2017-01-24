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
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("\n*** INVALID INPUT. PLEASE TRY AGAIN. ***\n");
                    PlayerMode();
                    break;
            }
        }

        public void DisplayBreakPoint()
        {
            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
        }


        public void DetermineWinner()
        {
            Console.WriteLine("\nWINNER =\n");
            Console.WriteLine("\nLOSER =\n");
        }


        public string GetAIChoice()
        {
            {
                String[] weapons = { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
                Random random = new Random();
                int index = random.Next(0, weapons.Length);
                return (weapons[index]);
            }
        }

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
            DetermineWinner();
            string weapon = GetAIChoice();
            //string choice = choiceToWeaponName();                     
        }
    }
}

    


