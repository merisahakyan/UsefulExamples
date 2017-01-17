g System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodToInt32
{
    class Program
    {
        public static int ToInt32(byte a, byte b, byte c, byte d)
        {
            string str = a.ToString() + b.ToString() + c.ToString() + d.ToString();
            return int.Parse(str);

        }
        static void Main(string[] args)
        {
            Console.WriteLine(ToInt32(2, 3, 5, 4));
        }
    }
}
