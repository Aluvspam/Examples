using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFT
{
    class ClassPlayerOvidiu : IPlayer, IScore
    {
        public int Score => throw new NotImplementedException();

        public Moves FirstMove()
        {
            return Moves.D;
        }



        public Moves MyMove(Moves myLastMove, Moves othersLastMove)
        {
            if (othersLastMove == Moves.D)
                return Moves.D;
            return Moves.C;

        }
    }


}
