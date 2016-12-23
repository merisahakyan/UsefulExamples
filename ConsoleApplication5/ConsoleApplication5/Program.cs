using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static int squareDigitsSequence(int a0)
        {
            int cur = a0;
            List<int> was = new List<int>();

            while (!was.Contains(cur))
            {
                was.Add(cur);
                int next = 0;
                while (cur > 0)
                {
                    next += (cur % 10) * (cur % 10);
                    cur /= 10;
                }
                cur = next;
            }

            return was.Count + 1;
        }


        static void Main(string[] args)
        {
            List<int> was = new List<int>();
            was.Add(1);
            was.Add(2);
            Console.WriteLine(!was.Contains(1));
            

        }
    }
}
