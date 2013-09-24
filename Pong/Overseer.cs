using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pong.Ball;

namespace Pong {
    public class Overseer {

        private WorldController worldController;

        public Overseer(WorldController wrld) {
            worldController = wrld;
        }

        public void UpdateBallData() {
            worldController.UpdateBallData();
        }

    }
}
