using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingDemo
{
    public struct Vector
    {
        public float startx;
        public float starty;
        public float endx;
        public float endy;

        public Vector(float sx, float sy, float ex, float ey)
        {
            startx = sx;
            endx = ex;
            starty = sy;
            endy = ey;
        }
        public static Vector operator +(Vector v1, Vector v2)
        {
            if (v1.endx == v2.startx && v1.endy == v2.starty)
                return new Vector(v1.startx, v1.starty, v2.endx, v2.endy);
            else
            {
                var v = new Vector();
                v.startx = v2.startx - (v2.startx - v1.endx);
                v.starty = v2.starty - (v2.starty - v1.starty);
                v.endx = v2.endx - (v2.startx - v1.endx);
                v.endy = v2.endy - (v2.starty - v1.starty);
                return new Vector(v1.startx, v1.starty, v.endx, v.endy);
            }

        }

    }
    
}
