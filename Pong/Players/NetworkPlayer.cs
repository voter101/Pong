using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pong.Players {
    class NetworkPlayer : Player {

        TCPServer.Server server;
        TCPClient.Client client;

        public NetworkPlayer(TCPServer.Server server, TCPClient.Client client) : base(Side.RIGHT) {
            this.server = server;
            this.client = client;
        }

        public void SendInformation(string message) {
            client.SendMessage(message);
        }

        public string GetNewInformation() {
            return server.GetMessage();
        }
    }
}
