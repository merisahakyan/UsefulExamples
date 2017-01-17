using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Demo
{

    

    class Program
    {
        static void Main(string[] args)
        {
            Vector vector1 = new Vector(0,0,1,1);
            Vector vector2 = new Vector(2,2,3,3);
            var vector = vector1 + vector2;
            Console.WriteLine($"New vectors coordinates are ({vector.startx},{vector.starty});({vector.endx},{vector.endy})");
            
            vector = vector1 - vector2;
            Console.WriteLine($"New vectors coordinates are ({vector.startx},{vector.starty});({vector.endx},{vector.endy})");
        }
    }
}

