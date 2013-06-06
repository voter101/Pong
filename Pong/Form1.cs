using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class Form1 : Form
    {
        private Players.HumanPlayer TestPlayer;
        public Form1()
        {
            InitializeComponent();
            TestPlayer = new Players.HumanPlayer(RightPalette, 0);
        }

        private void RightPalette_KeyPress(object sender, KeyPressEventArgs e)
        {
            TestPlayer.Move_KeyPressed(sender, e);
        }
    }
}
