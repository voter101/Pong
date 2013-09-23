using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong.Ball
{
    public class Reflection
    {
        public static readonly Reflection UP = new Reflection(180);
        public static readonly Reflection LEFT = new Reflection(0);
        public static readonly Reflection DOWN = new Reflection(180);
        public static readonly Reflection RIGHT = new Reflection(0);
        public static readonly Reflection NONE = null;
        
        public static IEnumerable<Reflection> Values
        {
            get
            {
                yield return UP;
                yield return LEFT;
                yield return DOWN;
                yield return RIGHT;
                yield return NONE;
            }
        }

        int angle;

        public int Angle
        {
            get { return angle; }
            set { angle = value; }
        }

        public Reflection(int angle)
        {
            this.angle = angle;
        }
    }
}
