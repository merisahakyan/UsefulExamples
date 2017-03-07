using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegularEx
{
    class Program
    {
        static void OnlyDigits()
        {   
            //with length 4
            string str;
            Regex rg = new Regex("^\\d\\d\\d\\d$", RegexOptions.Compiled);
            do
            {
                Console.WriteLine("Your input");
                str = Console.ReadLine();
            }
            while (!rg.IsMatch(str));
            Console.WriteLine("Great!");
        }
        static void DigitsAndSpaces()
        {
            //with lenth 4
            string str;
            Regex rg = new Regex("^\\d\\s*\\d\\s*\\d\\s*\\d\\s*?$", RegexOptions.Compiled);
            do
            {
                Console.WriteLine("Your input");
                str = Console.ReadLine();
            }
            while (!rg.IsMatch(str));
            Console.WriteLine("Great!");
        }
        static void Main(string[] args)
        {
            OnlyDigits();
            DigitsAndSpaces();
        }
    }
}
