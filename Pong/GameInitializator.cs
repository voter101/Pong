using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Pong.Connection;
using Pong.Players;
using Pong.Ball;

namespace Pong {
    public class GameInitializator {

        const int PORT = 1337;

        private static GameInitializator instance;
        private Player left;
        private Player right;
        private Server server;
        private Client client;
        private Boolean isServer;
        private Boolean offline = false;

        private GameInitializator() { }

        public static GameInitializator Instance {
            get {
                if (instance == null)
                    instance = new GameInitializator();
                return instance;
            }
        }

        public void StartServer(ushort port = PORT) {
            isServer = true;
            server = Server.Instance;
            client = Client.Instance;
            server.Initialize(port);
            if (server.Initialized())
                client.Initialize(server.GetClientIP(), port++);
            else
                throw new Exception("Cannot start connection");
        }

        public void ConnectToServer(string ip, ushort port = PORT) {
            isServer = false;
            client = Client.Instance;
            client.Initialize(ip, port);
            server = Server.Instance;
            if (client.Initialized())
                server.Initialize(port++);
            else
                throw new Exception("Cannot start connection");
        }

        public void OfflineMode() {
            offline = true;
        }

        public void InitializeGame() {
            if (!offline && (!client.Initialized() || !server.Initialized()))
                throw new Exception("Connection unitialized. Can't start a game");
            if (offline) {
                left = new HumanPlayer(Side.LEFT);
                right = new HumanPlayer(Side.RIGHT);
            } else if (isServer) {
                left = new HumanPlayer(Side.LEFT);
                right = new NetworkPlayer(Side.RIGHT);
            } else {
                left = new NetworkPlayer(Side.LEFT);
                right = new HumanPlayer(Side.RIGHT);
            }
            WorldController wrld = new WorldController(left, right, server, client, isServer);
            Overseer overseer = new Overseer(wrld);
            BallObject ball = new BallObject(left, right, overseer);
            wrld.AttachBall(ball);
            using (var game = new Pong(left, right, ball))
                game.Run();
        }

    }
}
