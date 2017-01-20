using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DirectoryTree;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            DirectionsTree.GetTree(@str);
            DirectionsTree.Print();
        }
    }
}
