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
            return Random.Move();
        }

        public Moves MyMove(Moves myLastMove, Moves othersLastMove)
        {
            return RandomMove();
        }

        private Moves RandomMove()
        {
            return (rnd.Next(2) == 0) ? Moves.C : Moves.D;
        }

    }
}
