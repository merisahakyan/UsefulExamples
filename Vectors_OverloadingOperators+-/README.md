##Overloading Operators (example for geometric vectors)</br>
###Adding and Subtracting Vectors</br>
We use triangle method for adding two vectors. Draw the vectors one after another, placing the initial point </br>
of each successive vector at the terminal point of the previous vector. Then draw the resultant from the </br>
initial point of the first vector to the terminal point of the last vector. This method is also called the</br>
head-to-tail method .</br>
###Vector Addition:
![](https://github.com/marysahakyan/UsefulExamples/blob/master/Vectors_OverloadingOperators%2B-/addition.gif)
###Vector Subtraction:
![](https://github.com/marysahakyan/UsefulExamples/blob/master/Vectors_OverloadingOperators%2B-/subtraction.gif)
There are class **Vectror** with _float_ fields _startx,starty,endx,endy_. The class has 2 constructors: first is default</br>
which initializes fields with 0,0,0,0 values, second constructor has 4 _float_ arguments.  </br>
**The overloaded operators + and -**
If the vectors aren't after one another, the method transvers second vector to te end of the first.
```cs
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
```
