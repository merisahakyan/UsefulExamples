using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class DeriveClass1:BaseClass
    {
        private string s;
        private DateTime dt;

        public override void Meth1(string  s)
        {
            s = "#" + s + "#";
            Console.WriteLine($"Meth1 in DeriveClass1. Argument's value is {s}"); ;
        }

        public new void Meth2(int a)
        {
            a = a * a * a;
            Console.WriteLine($"Meth2 in DeriveClass1.Argument's cube is {a}");
        }

        public  void Meth3()
        { s = "01/01/2017 01:01:01.01";
            dt = Convert.ToDateTime(s);
            Console.WriteLine($"Meth3 in DeriveClass1. DateTime is {dt}");
        }
    }
}
