using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Human : Player
    {

        public override void SetChoice()
        {
            Console.WriteLine("Choose any weapon of your choice! Type a weapon of your choice: ROCK, PAPER, SCISSORS, LIZARD OR SPOCK.");
            this.weapon = Console.ReadLine().ToLower();
            Console.Clear();
        }
        public override string GetChoice()
        {
            return this.weapon;
        }
    }
}
