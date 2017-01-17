public class Vector
{
    public float startx;
    public float starty;
    public float endx;
    public float endy;
    public Vector()
    {
        startx = 0;
        starty = 0;
        endx = 0;
        endy = 0;
    }
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
            v.starty = v2.starty - (v2.starty - v1.endy);
            v.endx = v2.endx - (v2.startx - v1.endx);
            v.endy = v2.endy - (v2.starty - v1.endy);
            return new Vector(v1.startx, v1.starty, v.endx, v.endy);
        }

    }

    public static Vector operator -(Vector v1, Vector v)
    {
        var v2 = new Vector(v.endx, v.endy, v.startx, v.starty);
        if (v1.endx == v2.startx && v1.endy == v2.starty)
            return new Vector(v1.startx, v1.starty, v2.endx, v2.endy);
        else
        {
            var vector = new Vector();
            vector.startx = v2.startx - (v2.startx - v1.endx);
            vector.starty = v2.starty - (v2.starty - v1.endy);
            vector.endx = v2.endx - (v2.startx - v1.endx);
            vector.endy = v2.endy - (v2.starty - v1.endy);
            return new Vector(v1.startx, v1.starty, vector.endx, vector.endy);
        }

    }

    public static float operator *(Vector v1, Vector v2)
    {

    }

}
