﻿using Microsoft.Xna.Framework;
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
    public class BallObject
    {
        private PathCalculator calculator = new PathCalculator();
        private Vector2 position;

        public Vector2 Position
        {
            get { return position; }
            set { position = value; }
        }
        private Texture2D texture;
        private int radius = 20;
        public int Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        private Player left;
        private Player right;
        private int speed = 10;
        private Random rand = new Random();
        private Overseer overseer;

        public BallObject(Player left, Player right, Overseer overseer) {
            this.left = left;
            this.right = right;
            this.overseer = overseer;
        }

        public void SetStartingParams(Vector2 position) {
            this.position = position;
            calculator.Angle = rand.Next();
            calculator.updateProportions();
        }

        public void loadTextures(Texture2D texture)
        {
            this.texture = texture;
        }

        public void updateBall(SpriteBatch sprites)
        {
            int newX = (int)Math.Round(speed * calculator.xProportion, 0);
            int newY = (int)Math.Round(speed * calculator.yProportion, 0);
            position.X = position.X + newX;
            position.Y = position.Y + newY;
            sprites.Draw(texture, position, Color.White);
            calculator.updateAngle(hitType());
            overseer.UpdateBallData();
            checkScore();
        }

        private Reflection hitType()
        {
            if (Reflection.LEFT == Reflection.RIGHT) left.position.Y = 1200;
            if (left.position.Y <= position.Y + radius * 2 && left.position.Y + 160 >= position.Y && 
                left.position.X + 40 >= position.X && position.X  >= left.position.X)
            {
                position.X = left.position.X + 40;
                return Reflection.LEFT;
            }
            if (right.position.Y <= position.Y + radius * 2 && right.position.Y + 160 >= position.Y &&
                right.position.X - 40 <= position.X && position.X <= right.position.X)
            {
                position.X = right.position.X - 40;
                return Reflection.RIGHT;
            }
            if (position.Y > 770 - 2 * radius)
            {
                position.Y = 770 - 2 * radius;
                return Reflection.DOWN;
            }
            if (position.Y < 30)
            {
                position.Y = 30;
                return Reflection.UP;
            }
            else
                return Reflection.NONE;
        }

        public override string ToString() {
            return position.X + ";" + position.Y + ";" + radius;
        }

        public void reset()
        {
            position = new Vector2(480-radius, 400-radius);
            calculator.Angle = rand.Next();

        }

        private void checkScore()
        {
            if (position.X <= 0)
            {
                right.score++;
                reset();
            }
            if (position.X >= 960)
            {
                left.score++;
                reset();
            }
        }

        internal void stop()
        {
            calculator.xProportion = 0;
            calculator.yProportion = 0;
        }
    }
}
