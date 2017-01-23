using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Player
    {
        public string name;
        public virtual void GetPlayerName()
        {
            Console.WriteLine("Please enter your Name:");
            name = Console.ReadLine();
        }

        public void PrintPlayerName()
        {
            Console.WriteLine($"{name}, get ready to defeat your opponent!\n");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n\n");

        }

        public string GetHumanChoice()
        {
            Console.WriteLine("Choose any weapon of your choice! Enter a letter that corresponds: \nA.) Rock \nB.) Paper \nC.) Scissors \nD.) Lizard \nE.) Spock");
            string choice = Console.ReadLine().ToUpper();
            switch (choice)
            {
                case "A":
                    Console.WriteLine("Rock");
                    choice = "Rock";
                    break;
                case "B":
                    Console.WriteLine("Paper");
                    choice = "Paper";
                    break;
                case "C":
                    Console.WriteLine("Scissors");
                    choice = "Scissors";
                    break;
                case "D":
                    Console.WriteLine("Lizard");
                    choice = "Lizard";
                    break;
                case "E":
                    Console.WriteLine("Spock");
                    choice = "Spock";
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("***INVALID INPUT. PLEASE TRY AGAIN.***");
                    GetHumanChoice();
                    break;
            }
            return choice;
        }       

    }

}
