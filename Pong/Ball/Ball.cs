using Microsoft.VisualBasic.PowerPacks;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Pong.Ball
{
    class BallObject
    {
        private PathCalculator calculator = new PathCalculator();
        private OvalShape ball;

        public BallObject(OvalShape ball)
        {
            this.ball = ball;
            Random rand = new Random();
            calculator.angleSet = rand.Next();
            calculator.updateProportions();
        }

        public void updateBall(object sender, EventArgs e)
        {
            int newX = (int)Math.Round(5 * calculator.xProportion, 0);
            int newY = (int)Math.Round(5 * calculator.yProportion, 0);
            ball.Location = new Point(ball.Location.X + newX, ball.Location.Y + newY);
            calculator.updateAngle(hitType());

        }

        private Reflection hitType()
        {
            if (ball.Location.X > 1000 || ball.Location.X < 60) 
                return Reflection.HORIZONTAL;
            else if(ball.Location.Y > 760 || ball.Location.Y < 60)
                return Reflection.VERTICAL;
            else 
                return Reflection.NONE;
        }
    }
}
