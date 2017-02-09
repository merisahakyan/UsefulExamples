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
            
        }
    }
}
