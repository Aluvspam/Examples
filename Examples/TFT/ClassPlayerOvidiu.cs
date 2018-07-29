using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFT
{
    class ClassPlayerOvidiu : IPlayer, Iscore
    {
        public Moves FirstMove()
        {
            return RandomMove()
        }

        public Moves MyMove(Moves myLastMove, Moves othersLastMove)
        {
            return RandomMove();

        }
    }

    internal interface Iscore
    {
    }
}
