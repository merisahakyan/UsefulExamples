using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMembers
{
    public class A
    {
        public virtual void AAA()
        {
            Console.WriteLine("class a");
        }
    }
    public class B:A
    {
        public override void AAA()
        {
            Console.WriteLine("class b");
        }
    }
    public class C : B
    {
        public new void AAA()
        {
            Console.WriteLine("class c");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            A b = new B();
            A c = new C();
            a.AAA();
            b.AAA();
            c.AAA();
            Console.ReadLine();
        }
    }
}
