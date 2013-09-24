using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pong.Connection {
    static class MessageAnalyzer {

        private static string[] splittedMessage;

        public static Message Analyze(string message) {
            splittedMessage = message.Split(';');
            if (splittedMessage.Count() == 4) {
                string[] player1 = new string[2];
                player1[0] = splittedMessage[0];
                player1[1] = splittedMessage[1];
                string[] player2 = new string[2];
                player2[0] = splittedMessage[2];
                player2[1] = splittedMessage[3];
                return analyzePlayersVectors(player1, player2);
            } else if (splittedMessage.Count() == 3) {
                string[] ball = new string[3];
                ball[0] = splittedMessage[0];
                ball[1] = splittedMessage[1];
                ball[2] = splittedMessage[2];
                return analyzeBallVector(ball);
            } else {
                throw new Exception("Can't Analyze message");
            }
        }

        private static Message analyzePlayersVectors(string[] vector1, string[] vector2) {
            float x1 = float.Parse(vector1[0]);
            float y1 = float.Parse(vector1[1]);
            Vector2 player1 = new Vector2(x1, y1);
            float x2 = float.Parse(vector2[0]);
            float y2 = float.Parse(vector2[1]);
            Vector2 player2 = new Vector2(x2, y2);
            return new Message(player1, player2);
        }

        private static Message analyzeBallVector(string[] data) {
            float x1 = float.Parse(data[0]);
            float y1 = float.Parse(data[1]);
            int radius = int.Parse(data[2]);
            Vector2 ball = new Vector2(x1, y1);
            return new Message(ball, radius);
        }

    }
}
