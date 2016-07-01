using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
   class ShortAttentionSpanAI : IPlayer
    {
        int savedPlayed;

        //NextMove() plays the move that would win against the opponent's previous move
        public int NextMove()
        {
            if (savedPlayed == 0)
            {
                return 1;
            }
            if (savedPlayed == 1)
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }

        //SaveResult() does something with the passed-in values to make NextMove work
        public void SaveResult(int myMove, int otherMove)
        {
            savedPlayed =otherMove;
        }
    }
}
