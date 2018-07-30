using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFT
{
    class Cristian: IPlayer,IScore
    {
        public int Score
        {
            get
            {
                return 0;
            }
        }

        Dictionary<String,int> Scor;
    

        public Cristian()
        {
            Scor = new Dictionary<String, int>();
        }

        public Moves FirstMove()
        {

           // Scor.Add(Moves.C, 0);
            return Moves.C;
            
        }

        public void ScoreAdding(Moves myLastMove, Moves othersLastMove)
        {
            Scor.Add("" + myLastMove + othersLastMove , Score);
        }

        public Moves MyMove(Moves myLastMove, Moves othersLastMove)
        {
            ScoreAdding( myLastMove,  othersLastMove);

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
                return Moves.C;
            }
        }

        //private Moves RandomMove()
        //{
        //    return (rnd.Next(2) == 0) ? Moves.C : Moves.D;
        //}

    }
}

