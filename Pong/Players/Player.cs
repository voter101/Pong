using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Pong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong.Players {
    public abstract class Player {
        protected Side side;
        public Texture2D texture;
        public Vector2 position;
<<<<<<< HEAD
        public int score = 0;

        public Player(Side side)
        {
=======

        public Player(Side side) {
>>>>>>> 0210ae188603a391094475f91fca69022a022490
            this.side = side;
            if (side == Side.LEFT) {
                position = new Vector2(20, 320);
            } else {
                position = new Vector2(900, 320);
            }
        }

        public void loadTextures(Texture2D texture) {
            this.texture = texture;
        }

<<<<<<< HEAD
        public void updatePlayer(SpriteBatch sprites) 
        {
            if (position.Y > 770 - 160)
                position.Y = 770 - 160;
            if (position.Y < 30)
                position.Y = 30;
=======
        public void updatePlayer(SpriteBatch sprites) {
>>>>>>> 0210ae188603a391094475f91fca69022a022490
            sprites.Draw(texture, position, Color.White);
        }

        public void SendInformation(string message) { }
    }
}
