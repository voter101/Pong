using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.PowerPacks;
using System.Windows.Forms;
using System.Drawing;

namespace Players
{
    public class ControlMethod
    {
        protected RectangleShape Palette;
        protected int Difficulty;

        public ControlMethod(RectangleShape palette, int difficulty)
        {
            this.Palette = palette;
            this.Difficulty = difficulty;
        }
    }

    public class HumanPlayer : ControlMethod
    {
        public HumanPlayer(RectangleShape palette, int difficulty) : base (palette, difficulty) 
        {
            Palette.KeyPress += new KeyPressEventHandler(Move_KeyPressed);
        }
        public void Move_KeyPressed (object sender, KeyPressEventArgs e)
        {
            if (Palette.Location.Y < 540 && e.KeyChar == 's') Palette.Location = new Point(Palette.Location.X, Palette.Location.Y+5);
            if (Palette.Location.Y > 30 && e.KeyChar == 'w') Palette.Location = new Point(Palette.Location.X,Palette.Location.Y-5);
        }

    }

    public class Player
    {
        private RectangleShape Palette;
        private int Difficulty;
        private ControlMethod Cont;
        public Player(RectangleShape palette,bool isAi,int difficulty=1)
        {
            this.Palette = palette;
            //if (isAi) Cont = new Ai(Palette, Difficulty); else 
            Cont = new HumanPlayer(Palette, Difficulty);
            this.Difficulty = difficulty;
        }
    }

}
