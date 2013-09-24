using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Pong.Players;
using Pong.Ball;
using Pong.Connection;

namespace Pong {
    class WorldController {

        private Player left;
        private Player right;
        private BallObject ball;
        private Thread receiver;
        private Thread sender;
        private Server server;
        private Client client;
        private Boolean isServer;

        public WorldController(Player player1, Player player2, BallObject ball, 
            Server server, Client client, Boolean isServer) {
            left = player1;
            right = player2;
            this.ball = ball;
            this.server = server;
            this.client = client;
            this.isServer = isServer;
            initializeWorld();
        }


        private void initializeWorld() {
            receiver = new Thread(new ThreadStart(receiveData));
            sender = new Thread(new ThreadStart(sendDataUpdate));
        }

        private void receiveData() {
            while (true) {
                if (isThereConnection()) {
                    string message = server.GetMessage();
                    if (message != null)
                        processMessage(message);
                } else {
                    break;
                }
            }
        }

        private Boolean isThereConnection() {
            return (left is NetworkPlayer || right is NetworkPlayer) &&
                (server.Initialized() && client.Initialized());
        }

        private void sendDataUpdate() {
            while (true) {
                if (isThereConnection()) {
                    string message = right.position.ToString() + ";"
                        + left.position.ToString(); // Left is always local player - we need to cross
                    client.SendMessage(message);
                } else {
                    break;
                }
                Thread.Sleep(20);
            }
        }

        private void processMessage(string message) {
            Message analyzedMessage = MessageAnalyzer.Analyze(message);
            if (analyzedMessage.VectorCount == 2)
                updatePlayersPositions(analyzedMessage.Vectors[0], analyzedMessage.Vectors[1]);
            else if (analyzedMessage.VectorCount == 1)
                updateBall(analyzedMessage.Vectors[0], analyzedMessage.Radius);
        }

        public void UpdateBallData() {
            if (isServer && isThereConnection()) {
                string message = ball.ToString();
                client.SendMessage(message);
            }
        }

        private void updateBall(Vector2 vector, int radius) {
            ball.Position = vector;
            ball.Radius = radius;
        }

        private void updatePlayersPositions(Vector2 left, Vector2 right) {
            this.left.position = left;
            this.right.position = right;
        }

    }
}
