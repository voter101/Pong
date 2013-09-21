using Pong.Players;
using Pong.Ball;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Board board = new Board();
            BallObject ball = new BallObject(board.getBall());
            board.timer.Tick += ball.updateBall;
            HumanPlayer test1 = new HumanPlayer(board, Side.LEFT);
            HumanPlayer test2 = new HumanPlayer(board, Side.RIGHT);
            
            
            Application.Run(board);
        }
    }
}
