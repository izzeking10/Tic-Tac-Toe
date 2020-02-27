using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    public class GameBoard
    {
        public class Position {
            public int x;
            public int y;
        }
        public string userTurn;
        List<Position> positions = new List<Position>();
        public void AddPosition(int x, int y)
        {
            Position p = new Position();
            p.x = x;
            p.y = y;
            positions.Add(p);
        }
        /*
        public bool ThreeInARow()
        {
            if ()
        }*/
    }
}
