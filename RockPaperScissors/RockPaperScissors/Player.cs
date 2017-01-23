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
            return choice;

        }

        public void PrintHumanChoice(string choice)
        {

            switch (choice)
            {
                case "A":
                    Console.WriteLine("Rock");
                    //playerOne = new Human();
                    //playerTwo = new Human();
                    break;
                case "B":
                    Console.WriteLine("Paper");
                    //playerOne = new Human();
                    //playerTwo = new Human();
                    break;
                case "C":
                    Console.WriteLine("Scissors");
                    //playerOne = new Human();
                    //playerTwo = new Human();
                    break;
                case "D":
                    Console.WriteLine("Lizard");
                    //playerOne = new Human();
                    //playerTwo = new Human();
                    break;
                case "E":
                    Console.WriteLine("Spock");
                    //playerOne = new Human();
                    //playerTwo = new Human();
                    Console.ReadLine();
                    break;
                default:
                    break;

            }

        }

    }

}
