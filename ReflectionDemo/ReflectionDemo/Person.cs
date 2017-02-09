using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    public class Person
    {
        public int PersonID;
        public string Name { get; set; }
        public string SurName { get; set; }
        public DateTime BirthDate { get; set; }

        public Person()
        {
            Name = "name";
            SurName = "surname";
            BirthDate = DateTime.Now;
        }
        public Person(string name, string surname, DateTime birth)
        {
            Name = name;
            SurName = surname;
            BirthDate = birth;
        }

        public string GetName()
        {
            return this.Name;
        }
        public string GetSurName()
        {
            return this.SurName;
        }
        public int BirthDay()
        {
            return BirthDate.Day;
        }
        public int BirthMonth()
        {
            return this.BirthDate.Month;
        }
    }
}
