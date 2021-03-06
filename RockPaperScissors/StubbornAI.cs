﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class StubbornAI : IPlayer
    {
        public int FavoriteMove { get; set; }

        public StubbornAI(int favoriteMove)
        {
            favoriteMove = 0;
            FavoriteMove = favoriteMove;
        }

        // NextMove() always plays favoriteMove
        public int NextMove()
        {
            return FavoriteMove;
        }

        public void SaveResult(int myMove, int otherMove)
        {
            //method intentionally left blank because we don't want it to do anything
        }
    }
}
