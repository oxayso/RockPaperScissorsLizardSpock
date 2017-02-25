using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class AI : Player 
    {
        public override void SetPlayerName()
        {
            name = "A.I Uzumaki";
        }

        public override void SetChoice()
        {
            {
                Random random = new Random();
                String[] weapons = { "rock", "paper", "scissors", "lizard", "spock" };
                this.weapon = weapons[random.Next(0, weapons.Length)];
                Console.Clear();
            }
        }

    }
}
