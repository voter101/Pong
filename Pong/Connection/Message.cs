using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pong.Players;
using Pong.Ball;

namespace Pong.Connection {
    class Message {

        public int VectorCount; 
        public int Radius;
        public Vector2[] Vectors;

        public Message(Vector2 player1Position, Vector2 player2Position) {
            VectorCount = 2;
            Vectors = new Vector2[2];
            Vectors[0] = player1Position;
            Vectors[1] = player2Position;
        }

        public Message(Vector2 ballPosition, int radius) {
            VectorCount = 1;
            Vectors = new Vector2[1];
            Vectors[0] = ballPosition;
            this.Radius = radius;
        }

    }
}
