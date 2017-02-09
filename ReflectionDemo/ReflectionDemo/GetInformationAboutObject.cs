using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionDemo
{
    public class GetInformationAboutObject
    {
        public void GetMethods(object obj)
        {
            Console.WriteLine("*****Methods*****");
            Type t = obj.GetType();
            MethodInfo[] mi = t.GetMethods();
            foreach (MethodInfo m in mi)
                Console.WriteLine(m);
            Console.WriteLine();
        }

        public void GetMemberInfo(object obj)
        {
            Console.WriteLine("*****Members*****");
            Type t = obj.GetType();
            MemberInfo[] mi = t.GetMembers();
            foreach (var item in mi)
                Console.WriteLine(item);
            Console.WriteLine();
        }
        public void GetPropertyInfo(object obj)
        {
            Console.WriteLine("*****Properties*****");
            Type t = obj.GetType();
            PropertyInfo[] mi = t.GetProperties();
            foreach (var item in mi)
                Console.WriteLine(item);
            Console.WriteLine();
        }
        public void GetFieldInfo(object obj)
        {
            Console.WriteLine("*****Fields*****");
            Type t = obj.GetType();
            FieldInfo[] mi = t.GetFields();
            foreach (var item in mi)
                Console.WriteLine(item);
            Console.WriteLine();
        }
        public void GetAssembly(object obj)
        {
            Console.WriteLine("*****AssemblyInfo*****");
            Type t = obj.GetType();
            Assembly mi = t.Assembly;
            Console.WriteLine(mi);
            Console.WriteLine();
        }

        public void GetInterfaceInfo(object obj)
        {
            Console.WriteLine("*****Interfaces*****");
            Type t = obj.GetType();
            var intfaces = from b in t.GetInterfaces() select b;
            foreach (var item in intfaces)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

    }
}
