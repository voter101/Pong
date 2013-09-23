using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Pong.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Pong.Ball
{
    class BallObject
    {
        private PathCalculator calculator = new PathCalculator();
        private Vector2 position;
        private Texture2D texture;
        private int radius = 20;

        private Player left;
        private Player right;
        

        public BallObject(Vector2 position, Player left, Player right)
        {
            this.position = position;
            this.left = left;
            this.right = right;
            Random rand = new Random();
            calculator.Angle = 275; // rand.Next();
            calculator.updateProportions();
        }

        public void loadTextures(Texture2D texture)
        {
            this.texture = texture;
        }

        public void updateBall(SpriteBatch sprites)
        {
            
            int newX = (int)Math.Round(5 * calculator.xProportion, 0);
            int newY = (int)Math.Round(5 * calculator.yProportion, 0);
            position.X = position.X + newX;
            position.Y = position.Y + newY;
            sprites.Draw(texture, position, Color.White);
            calculator.updateAngle(hitType());

        }

        private Reflection hitType()
        {
            if ( (left.position.Y <= position.Y - radius * 2 && left.position.Y + 160 >= position.Y && left.position.X + 40 == position.X) ||
                 (right.position.Y <= position.Y - radius * 2 && right.position.Y + 160 >= position.Y && right.position.X == position.X) ) 
                return Reflection.HORIZONTAL;
            else if (position.Y > 800 - 2 * radius || position.Y < 0)
                return Reflection.VERTICAL;
            else 
                return Reflection.NONE;
        }

        public string ToString() {
            return position.X + ";" + position.Y + ";" + radius;
        }
    }
}
