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
        public int Angle
        { 
            get {return angle;}
            set
            {
                angle = value % 360;
                if (angle < 0) angle += 360;
                updateProportions();
            }
        }
        public double xProportion;
        public double yProportion;
        private Random rand = new Random();

        public void updateAngle(Reflection type)
        {
            if (type != Reflection.NONE)
            {
                Angle = type.Angle - Angle;
                Angle += rand.Next(20) - 10;
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
