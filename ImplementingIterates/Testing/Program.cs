using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImplementingIterators;
using System.Collections;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = new List<int>(10);
            ints.Add(1);
            ints.Add(2);
            ints.Add(3);
            ints.Add(4);
            ints.Add(5);
            Derived<int> dint = new Derived<int>(ints);
            for (int i = 0; i < ints.Count; i++)
                if (dint.MoveNext())
                    Console.WriteLine(dint.Current);
                else
                    dint.Reset();
            dint.Reset();
            Console.WriteLine("-------------");
            for (int i = 0; i < ints.Count; i++)
                if (dint.MoveNext())
                    Console.WriteLine(dint.Current);
                else
                    dint.Reset();
            Console.WriteLine("Iterates-------------");
            var en = GetIntegers();

            foreach (var item in en)
            {
                Console.WriteLine(item);
            }
        }
        public static IEnumerable GetIntegers()
        {
            yield return 1;
            yield return 2;
            yield return 3;
            yield return 4;
            yield return 5;
            
        }
    }
}
