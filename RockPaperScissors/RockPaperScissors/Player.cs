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
            Console.WriteLine($"\n{name}, get ready to defeat your opponent!\n");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n\n");

        }

        public string GetHumanChoice()
        {
            Console.WriteLine("Choose any weapon of your choice! Enter a letter that corresponds: \nA.) Rock \nB.) Paper \nC.) Scissors \nD.) Lizard \nE.) Spock");
            string choice = Console.ReadLine().ToUpper();
            switch (choice)
            {
                case "A":
                    Console.WriteLine("\nWeapon Selection = Rock\n");
                    choice = "Rock";
                    break;
                case "B":
                    Console.WriteLine("\nWeapon Selection = Paper\n");
                    choice = "Paper";
                    break;
                case "C":
                    Console.WriteLine("\nWeapon Selection = Scissors\n");
                    choice = "Scissors";
                    break;
                case "D":
                    Console.WriteLine("\nWeapon Selection = Lizard\n");
                    choice = "Lizard";
                    break;
                case "E":
                    Console.WriteLine("\nWeapon Selection = Spock\n");
                    choice = "Spock";
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("\n*** INVALID INPUT. PLEASE TRY AGAIN. ***\n");
                    GetHumanChoice();
                    break;
            }
            return choice;
        }       

    }

}
