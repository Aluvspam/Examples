using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFT
{
    class CristiPlayer: IPlayer,IScore
    {
        public int Score {
            get
            {
                return 0;
            }
        }

        Random rnd;

        public CristiPlayer()
        {
            rnd = new Random();
        }

        public Moves FirstMove()
        {
            return RandomMove();
        }

        public Moves MyMove(Moves myLastMove, Moves othersLastMove)
        {
            if (othersLastMove == Moves.B)
            {
                return Moves.C;
            }
            else if (othersLastMove == Moves.C)
            {
                return Moves.D;
            }
            else if (othersLastMove == Moves.D)
            {
                return Moves.D;
            }
            else
            {
                return RandomMove();
            }
        }

        private Moves RandomMove()
        {
            return (rnd.Next(2) == 0) ? Moves.C : Moves.D;
        }

    }
}
