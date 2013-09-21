using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong.Players
{
    public class HumanPlayer : ControlMethod
    {
        private Keys upKey;
        private Keys downKey;

        public HumanPlayer(Board board, Side side)
            : base(board, side)
        {
            this.board.KeyDown += new System.Windows.Forms.KeyEventHandler(this.move_KeyDown);

            if (side == Side.LEFT)
            {
                this.upKey = Keys.W;
                this.downKey = Keys.S;
                this.paddle = board.getPlayerL();
            }
            else
            {
                this.upKey = Keys.O;
                this.downKey = Keys.L;
                this.paddle = board.getPlayerR();
            }

        }

        public async void move_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == upKey)
            {
                if (paddle.Location.Y - 10 > 60)
                {
                    paddle.Location = new Point(paddle.Location.X, paddle.Location.Y - 10);
                    await Task.Delay(5);
                }
            }

            if (e.KeyData == downKey)
            {
                if (paddle.Location.Y + 10 < 580)
                {
                    paddle.Location = new Point(paddle.Location.X, paddle.Location.Y + 10);
                    await Task.Delay(5);
                }
            }
        }
    }
}
