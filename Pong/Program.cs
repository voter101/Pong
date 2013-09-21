﻿using Pong.Players;
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
            HumanPlayer test1 = new HumanPlayer(board, Side.LEFT);
            HumanPlayer test2 = new HumanPlayer(board, Side.RIGHT);
            Application.Run(board);
        }
    }
}
