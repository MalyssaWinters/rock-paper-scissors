using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class RandomAI : IPlayer
    {
        Random random = new Random(); //put outside so the random number generator only constructs once

        public int NextMove()
        {
            //values that could return: 0:Rock, 1:Paper, or 2:Scissors
            return random.Next(0, 3); //put 3 because it will go up to everything but 3
        }

        public void SaveResult(int myMove, int otherMove)
        {
            //method intentionally left blank because we don't want it to do anything
        }
    }
}
