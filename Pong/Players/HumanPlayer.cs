using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Pong.Players
{
    public class HumanPlayer : Player
    {
        private Keys upKey;

        public Keys UpKey
        {
            get { return upKey; }
            set { upKey = value; }
        }
        private Keys downKey;

        public Keys DownKey
        {
            get { return downKey; }
            set { downKey = value; }
        }

        

        public HumanPlayer(Side side)
            : base(side)
        {
            if (side == Side.LEFT)
            {
                this.upKey = Keys.W;
                this.downKey = Keys.S;
            }
            else
            {
                this.upKey = Keys.Up;
                this.downKey = Keys.Down;
            }

        }
    }
}
