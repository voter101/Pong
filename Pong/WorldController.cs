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

        public WorldController(Player player1, Player player2, BallObject ball, Server server, Client client, Boolean isServer) {
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
            sender = new Thread(new ThreadStart(sendUpdateData));
        }
        
        private void receiveData() {
            while (true) {
                if (left is NetworkPlayer)
                    processData(((NetworkPlayer)left).GetNewInformation());
                if (right is NetworkPlayer)
                    processData(((NetworkPlayer)right).GetNewInformation());
            }
        }

        private void sendUpdateData() {
            while (true) {
                string message = left.position.ToString() + ";" + right.position.ToString();
                if (left is NetworkPlayer)
                    ((NetworkPlayer)left).SendInformation(message);
                if (right is NetworkPlayer)
                    ((NetworkPlayer)right).SendInformation(message);
                Thread.Sleep(20);
            }
        }

        private void processData(string message) {
            Message analyzedMessage = MessageAnalyzer.Analyze(message);
        }

        public void UpdateBallStatus() {
            if (!isServer)
                throw new Exception("Only server can update Ball status");
            if (left is NetworkPlayer)
                ((NetworkPlayer)left).SendInformation(ball.ToString());
            if (right is NetworkPlayer)
                ((NetworkPlayer)right).SendInformation(ball.ToString());
        }

        private void updatePlayersPositions(Vector2 left, Vector2 right) {

        }

    }
}
