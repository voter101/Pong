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

        public int score = 0;

        public Player(Side side) {
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

        public void updatePlayer(SpriteBatch sprites) 
        {
            if (position.Y > 770 - 160)
                position.Y = 770 - 160;
            if (position.Y < 30)
                position.Y = 30;
            sprites.Draw(texture, position, Color.White);
        }

        public override string ToString() {
            return position.X.ToString() + ';' + position.Y.ToString();
        }
    }
}
