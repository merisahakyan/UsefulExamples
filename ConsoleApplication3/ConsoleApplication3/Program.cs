using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 3, 4 };
            int[] b = { 1, 1, 0 };
            int x = a.Length;
            int y = b.Length;
            int z = x + y;
            int[] c = new int[z];
            for (int i = 0; i < z; i++)
                if (i < x)
                    c[i] = a[i];
                else
                    c[i] = b[i];
            
        }
    }
}
