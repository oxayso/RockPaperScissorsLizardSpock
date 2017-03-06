using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Game
    {
        public Player playerOne;
        public Player playerTwo;
        public int playerOneScore;
        public int playerTwoScore;

        public void DisplayRules()
        {
            Console.WriteLine("Let's play a classic: Rock, Paper, Scissors. \n\nUnder one condition... \n-The game has since expanded & thus, has "
                              +
                              "developed a new name: Rock, Paper, Scissors, Lizard, Spock... \n\nTHE RULES: \n\n-Scissors cuts Paper \n-Paper covers Rock \n-Rock "
                              +
                              "crushes Lizard \n-Lizard poisons Spock \n-Spock smashes Scissors \n-Scissors decapitates Lizard \n-Lizard eats Paper \n-Paper disproves"
                              +
                              "Spock \n-Spock vaporizes Rock \n(and as it always has...) \n-Rock crushes Scissors\n \n\nLET'S GO!\n\n");

            Console.WriteLine(
                "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
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
            Console.WriteLine(
                "\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
        }

        public bool DetermineWinner(string playerOne, string playerTwo)
        {

            if (playerOne == "rock" && (playerTwo == "scissors" || playerTwo == "lizard"))
            {
                return true;
            }
            else if (playerOne == "paper" && (playerTwo == "rock" || playerTwo == "spock"))
            {
                return true;
            }
            if (playerOne == "scissors" && (playerTwo == "lizard" || playerTwo == "paper"))
            {
                return true;
            }
            else if (playerOne == "lizard" && (playerTwo == "spock" || playerTwo == "paper"))
            {
                return true;
            }
            if (playerOne == "spock" && (playerTwo == "scissors" || playerTwo == "rock"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DisplayWinner(Player player)
        {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"\nThe winner is: {player.name} !!!!!");
                Console.ResetColor();
        }

        public void DisplayScore()
        {
            Console.WriteLine($"\n{playerOne.name} Chose: {playerOne.weapon} \n{playerTwo.name} Chose: {playerTwo.weapon}");
            Console.WriteLine($"\n\n[SCORES]:\n{playerOne.name} = {playerOneScore} \n{playerTwo.name} = {playerTwoScore}", playerOneScore, playerTwoScore);

        }

        public void RunGame()
        {
            DisplayRules();
            string opponent = PlayerMode();
            PlayerChoice(opponent);
            DisplayBreakPoint();
            playerOne.SetPlayerName();
            playerTwo.SetPlayerName();
            playerOne.PrintPlayerName();
            playerTwo.PrintPlayerName();
            playerOneScore = 0;
            playerTwoScore = 0;

            while (playerOneScore < 2 && playerTwoScore < 2)
            {
                    playerOne.SetChoice();
                    playerTwo.SetChoice();
                    if (playerOne.weapon == playerTwo.weapon)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("\nTIE !!!!! Nobody wins this round :(");
                        Console.ResetColor();
                    }
                    else
                    {
                        if (DetermineWinner(playerOne.weapon, playerTwo.weapon))
                        {
                            playerOneScore++;
                            DisplayScore();
                        }
                        else
                        {
                            playerTwoScore++;
                            DisplayScore();
                        }

                    }        
            }

            if (playerOneScore == 2)
            {
                DisplayWinner(playerOne);
            }
            else
            {
                DisplayWinner(playerTwo);
            }

            Console.WriteLine("\n\nWOULD YOU LIKE TO PLAY AGAIN?!?!?!? \n[Y] YES! \n[N] NO!");
            if ("y" == Console.ReadLine().ToLower())
            {
                RunGame();
            }

        }

    }
}

    


