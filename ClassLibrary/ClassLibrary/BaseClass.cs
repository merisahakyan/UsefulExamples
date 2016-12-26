using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class BaseClass
    { 
        private DateTime dt;

        public virtual void Meth1(string  s)
        {
            s="*"+s+"*";
            Console.WriteLine($"Meth1 in BaseClass. Argument's value is {s}");
        }

        public virtual void Meth2(int a)
        {
            a = a * a;
            Console.WriteLine($"Meth2 in BaseClass.Argument's square is {a}");
        }

        public virtual void Meth3()
        { dt = DateTime.Now;
            Console.WriteLine($"Meth3 in BaseClass. DateTime.Now is {dt}");
        }
    }

}
