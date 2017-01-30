using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandMadeLINQ;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection1 = Enumerable.Range(10, 20);
            var collection2 = Enumerable.Range(20, 30);

            Console.WriteLine("Practice with LINQ");

            Console.WriteLine("LINQ Select");
            foreach (var item in collection1.Select(x => 2 * x))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("LINQ Where");
            foreach (var item in collection1.Where(x => !(x % 2 == 1)))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("LINQ Concat");
            foreach (var item in collection1.Concat(collection2))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("LINQ Contains");
            Console.WriteLine(collection1.Contains(5));

            Console.WriteLine("LINQ Count");
            Console.WriteLine(collection1.Count());

            Console.WriteLine("LINQ Distinct");
            foreach (var item in collection1.Distinct())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("LINQ Max");
            Console.WriteLine(collection1.Max());

            Console.WriteLine("LINQ Min");
            Console.WriteLine(collection1.Min());

            Console.WriteLine("LINQ Reverse");
            foreach (var item in collection1.Reverse())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("LINQ Sum");
            Console.WriteLine(collection1.Sum());


            Console.WriteLine("Practice with HandMadeLINQ");



            Console.WriteLine("MyLINQ MySelect");
            foreach (var item in collection1.MySelect(x => 2 * x))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("MyLINQ MyWhere");
            foreach (var item in collection1.MyWhere(x => !(x % 2 == 1)))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("MyLINQ MyConcat");
            foreach (var item in collection1.MyConcat(collection2))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("MyLINQ MyContains");
            Console.WriteLine(collection1.MyContains(5));

            Console.WriteLine("MyLINQ MyCount");
            Console.WriteLine(collection1.Count());

            Console.WriteLine("MyLINQ MyDistinct");
            foreach (var item in collection1.MyDistinct())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("LINQ MyMax");
            Console.WriteLine(collection1.MyMax());

            Console.WriteLine("LINQ MyMin");
            Console.WriteLine(collection1.MyMin());

            Console.WriteLine("LINQ MyReverse");
            foreach (var item in collection1.MyReverse())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("LINQ MySum");
            Console.WriteLine(collection1.MySum());
        }
    }
}
