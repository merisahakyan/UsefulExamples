using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndexersDemo;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "one");
            dictionary.Add(2, "two");
            dictionary.Add(3, "three");
            dictionary.Add(4, "four");
            dictionary.Add(5, "five");
            dictionary.Add(6, "six");
            dictionary.Add(7, "seven");
            dictionary.Add(8, "eight");
            dictionary.Add(9, "nine");
            dictionary.Add(0, "zero");
            Indexers obj = new Indexers(dictionary);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(obj[i]);
            }

            try
            {
                Console.WriteLine(obj[10]);
            }
            catch(KeyNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //This is uncorrect code,because our indexer is readonly, it does'n consist set accesor
            //obj[0] = "not zero";
            

        }
    }
}
