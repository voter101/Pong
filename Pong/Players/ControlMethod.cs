using Microsoft.VisualBasic.PowerPacks;
using Pong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong.Players
{
    public abstract class ControlMethod
    {
        protected Board board;
        protected Side side;
        protected RectangleShape paddle;

        public ControlMethod(Board board, Side side)
        {
            this.board = board;
            this.side = side;
        }
    }
}
