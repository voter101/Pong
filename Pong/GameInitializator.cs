using Pong.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Pong.Connection;

namespace Pong {
    class GameInitializator{

        const int PORT = 1337;

        private static GameInitializator instance;
        private Player left;
        private Player right;
        private Ball.BallObject ball;
        private Thread threadReceiver;
        private Thread threadSender;
        private Server server;
        private Client client;
        private Boolean isServer;

        private GameInitializator() {}

        public static GameInitializator Instance {
            get {
                if (instance == null) 
                    instance = new GameInitializator();
                return instance;
            }
        }

        public void StartServer(ushort port = PORT) {
            isServer = true;
            server.Initialize(port); 
            client.Initialize(server.GetClientIP(), port);
        }

        public void ConnectToServer(string ip, ushort port = PORT) {
            isServer = false;
            client.Initialize(ip, port); 
            server.Initialize(port);
        }

        public void InitializeGame(Ball.BallObject ball) {
            if (!client.Initialized() || !server.Initialized())
                throw new Exception ("Connection unitialized. Can't start a game");
            left = new Players.HumanPlayer(0);
            right = new Players.NetworkPlayer(server, client);
            WorldController wctrl = new WorldController(left, right, ball, server, client, isServer);
        }

        
    }
}
