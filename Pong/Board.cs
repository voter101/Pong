using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Players;

namespace Pong
{
    public partial class Board : Form
    {
        private HumanPlayer TestPlayer;
        public Board()
        {
            InitializeComponent();
            TestPlayer = new HumanPlayer(RightPalette, 1);
            this.KeyPress += new KeyPressEventHandler(TestPlayer.Move_KeyPressed);
        }
    }
}
