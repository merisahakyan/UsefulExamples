using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass bc = new BaseClass();
            BaseClass bcd = new DeriveClass1();
            DeriveClass1 dc = new DeriveClass1();

            Console.WriteLine("BaseClass bc = new BaseClass();");
            bc.Meth1("name");
            bc.Meth2(5);
            bc.Meth3();

            Console.WriteLine("--------");

            Console.WriteLine("BaseClass bcd = new DeriveClass1();");
            bcd.Meth1("firstname");
            bcd.Meth2(5);
            bcd.Meth3();


            Console.WriteLine("--------");

            Console.WriteLine("DeriveClass1 dc = new DeriveClass1();");
            dc.Meth1("lastname");
            dc.Meth2(5);
            dc.Meth3();

            Console.ReadLine();
        }
    }
}
