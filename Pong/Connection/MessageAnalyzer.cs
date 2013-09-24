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
        }

        private static Message analyzePlayersVectors(string vector1, string vector2) {

        }

        private static Message analyzeBallVector(string vector) {

        }

    }
}
