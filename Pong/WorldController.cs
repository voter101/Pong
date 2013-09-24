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
    public class WorldController {

        private Player left;
        private Player right;
        private BallObject ball;
        private Thread receiver;
        private Thread sender;
        private Server server;
        private Client client;
        private Boolean isServer;

        // No more time... Got to do this
        public Client TCPClient {
            get {
                return client;
            }
        }

        public Server TCPServer {
            get {
                return server;
            }
        }

        public WorldController(Player player1, Player player2, 
            Server server = null, Client client = null, Boolean isServer = true) {
            left = player1;
            right = player2;
            this.server = server;
            this.client = client;
            this.isServer = isServer;
            initializeConnection();

        }

        public void AttachBall(BallObject ball) {
            this.ball = ball;
        }

        private void initializeConnection() {
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

        private void updatePlayersPositions(Vector2 left, Vector2 right) {
            this.left.position = left;
            this.right.position = right;
        }

        public void UpdateBallData() {
            if (isServer && isThereConnection()) {
                string message = ball.ToString();
                client.SendMessage(message);
            }
        }

        private void updateBall(Vector2 vector, int radius) {
            if (ball != null)
                ball.Position = vector;
            ball.Radius = radius;
        }
    }
}
