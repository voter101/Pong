using Pong.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Pong {
    class GameInitializator{

        const int PORT = 1337;

        private static GameInitializator instance;
        private Player playerLeft;
        private Player playerRight;
        private Ball.BallObject ball;
        private Thread thread;
        private TCPServer.Server server;
        private TCPClient.Client client;

        private GameInitializator() {}

        public static GameInitializator Instance {
            get {
                if (instance == null) 
                    instance = new GameInitializator();
                return instance;
            }
        }

        public void StartServer(ushort port = PORT) {
            server.Initialize(port); 
            client.Initialize(server.GetClientIP(), port);
        }

        public void ConnectToServer(string ip, ushort port = PORT) {
            client.Initialize(ip, port); 
            server.Initialize(port);
        }

        public void InitializeGame(Ball.BallObject ball) {
            if (!client.Initialized() || !server.Initialized())
                throw new Exception ("Connection unitialized. Can't start a game");
            playerLeft = new Players.HumanPlayer(0);
            playerRight = new Players.NetworkPlayer(server, client);
            this.ball = ball;
            thread = new Thread(new ThreadStart(updatePositionInformation));
            thread.Start();
        }

        public void UpdateBallStatus() {
            if (playerLeft is NetworkPlayer)
                ((NetworkPlayer)playerLeft).SendInformation(ball.ToString());
            if (playerRight is NetworkPlayer)
                ((NetworkPlayer)playerRight).SendInformation(ball.ToString());
        }
        
        private void updatePositionInformation() {
            while (true) {
                string message = playerLeft.position.ToString() + ";" + playerRight.position.ToString();
                if (playerLeft is NetworkPlayer)
                    ((NetworkPlayer)playerLeft).SendInformation(message);
                if (playerRight is NetworkPlayer)
                    ((NetworkPlayer)playerRight).SendInformation(message);
                Thread.Sleep(20);
            }
        }
    }
}
