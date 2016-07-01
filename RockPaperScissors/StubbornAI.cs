using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class StubbornAI : IPlayer
    {
        public int NextMove()
        {
            throw new NotImplementedException();
        }

        public void SaveResult(int myMove, int otherMove)
        {
            //method intentionally left blank because we don't want it to do anything
        }
    }
}
