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
    class Box
    {
        static Box()
        {
            Console.WriteLine("static ctor was called");
        }

        public Box()
        {
            Console.WriteLine("default ctor was calleds");
        }

        public static string Data { get { return "You are trying to get data"; } }

        public const int Foo = 7;
    }
    interface IA
    {
        
    }
    struct SA:IA
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            //A a = new A();
            //A b = new B();
            //A c = new C();
            //a.AAA();
            //b.AAA();
            //c.AAA();
            //var data = Box.Data;
            //var box = new Box();
            //var data2 = Box.Data;
            //var box2 = new Box();
            Console.WriteLine(3+"7"+6+1);
            Console.ReadLine();
        }
    }
}
