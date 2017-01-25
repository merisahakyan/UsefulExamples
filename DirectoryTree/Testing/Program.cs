using System;
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
