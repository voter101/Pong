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
        public HumanPlayer(RectangleShape palette, int difficulty)
            : base(palette, difficulty)
        {
            //Palette.KeyPress += new KeyPressEventHandler(this.Move_KeyPressed);
        }
        public async void Move_KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 's')
            {
                for (int i = 1; i < Difficulty * Difficulty; i++)
                {
                    if (Palette.Location.Y < 540) Palette.Location = new Point(Palette.Location.X, Palette.Location.Y + 1); else break;
                    await Task.Delay(5);
                }
            }
            if (e.KeyChar == 'w')
            {
                for (int i = 1; i < Difficulty * Difficulty; i++)
                {
                    if (Palette.Location.Y > 30) Palette.Location = new Point(Palette.Location.X, Palette.Location.Y - 1); else break;
                    await Task.Delay(5);
                }
            }
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
