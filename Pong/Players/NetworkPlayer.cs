using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pong.Connection;

namespace Pong.Players {
    class NetworkPlayer : Player {

        Server server;
        Client client;

        public NetworkPlayer(Server server, Client client) : base(Side.RIGHT) {
            this.server = server;
            this.client = client;
        }
    }
}
