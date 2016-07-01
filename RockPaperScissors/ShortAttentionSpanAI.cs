using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    /// <summary>
    /// The ShortAttentionSpanAI class will need to do something in SaveResult to keep track of moves 
    /// as it sees them. Once it has seen a move, it assumes that a player will play the same move again,
    /// and for its next move picks the move that will beat that move. For example, if it sees Rock, 
    /// it picks Paper as its next move (because Paper beats Rock).
    /// The ShortAttentionSpanAI should very quickly win against the StubbornAI.
    /// You can test this for yourself by adding the AI classes into the AIPlayers dictionary in the Program
    /// class, running the program, and choosing the AI vs AI menu option.
    /// </summary>
    /// <returns></returns>
    /// 
    class ShortAttentionSpanAI : IPlayer
    {
        //NextMove() plays the move that would win against the opponent's previous move
        //SaveResult() does something with the passed-in values to make NextMove work
        public int NextMove()
        {
            throw new NotImplementedException();
        }

        public void SaveResult(int myMove, int otherMove)
        {
            throw new NotImplementedException();
        }
    }
}
