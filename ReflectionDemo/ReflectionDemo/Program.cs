using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionDemo
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            GetInformationAboutObject get = new ReflectionDemo.GetInformationAboutObject();
            get.GetMethods(person);
            get.GetMemberInfo(person);
            get.GetPropertyInfo(person);
            get.GetFieldInfo(person);
            get.GetAssembly(person);
            get.GetInterfaceInfo(person);
            //*******
            Type t = person.GetType();
            Console.WriteLine($"Is type abstract?      {t.IsAbstract}");
            Console.WriteLine($"Is type sealed?        {t.IsSealed}");
            Console.WriteLine($"Is type generic?       {t.IsGenericTypeDefinition}");
            Console.WriteLine($"Is type a class type?  {t.IsClass}");


        }
    }
}
