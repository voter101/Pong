using Microsoft.VisualBasic.PowerPacks;
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
    public partial class Board : Form
    {
        public Board()
        {
            InitializeComponent();
        }

        public RectangleShape getPlayerL()
        {
            return playerL;
        }

        public RectangleShape getPlayerR()
        {
            return playerR;
        }

        public OvalShape getBall()
        {
            return ball;
        }
    }
}
