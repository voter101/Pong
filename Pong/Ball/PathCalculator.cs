using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong.Ball
{
    public class PathCalculator
    {
        private int angle;
        public int angleSet
        { 
            get {return angle;}
            set
            {
                angle = value % 360;
                if (angle < 0) angle += 360;
            }
        }
        public double xProportion { 
            get; 
            private set;
        }
        public double yProportion { 
            get;
            private set;
        }

        public void updateAngle(Reflection type)
        {
            if (type != Reflection.NONE)
            {
                angleSet = (type == Reflection.VERTICAL ? 180 : 0) - angle;
                updateProportions();
            }
        }


        public void updateProportions()
        {
            double radians = angle * Math.PI / 180;
            xProportion = Math.Sin(radians);
            yProportion = -Math.Cos(radians);
        }

    }
}
