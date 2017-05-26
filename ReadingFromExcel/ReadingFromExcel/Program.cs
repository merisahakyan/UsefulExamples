using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.IO;
using OfficeOpenXml;
using System.Runtime.Serialization.Formatters.Binary;
using LinqToExcel;

namespace ReadingFromExcel
{
    class Program
    {
        
        public static void ReadFromExcel()
        {
            List<Contact> contactslist = new List<Contact>();
            var excel = new ExcelQueryFactory(@"C:\Users\Dell\Desktop\contacts.xlsx");

            var contacts = (from c in excel.Worksheet<Row>("Sheet1")
                            select c).ToList();

            foreach (var m in contacts)
            {
                Contact c = new Contact();
                c.FullName = m["fullname"];
                c.CompanyName = m["company"];
                c.Country = m["country"];
                c.Position = m["position"];
                c.Email = m["email"];
                c.DateInserted = Convert.ToDateTime(m["datainserted"]);
                c.GuID = Guid.NewGuid();
                contactslist.Add(c);
            }
            foreach (var item in contactslist)
            {
                Console.WriteLine($"{item.FullName}   {item.DateInserted}");
            }
        }

        public static void ReadFromCsv()
        {
            List<Contact> contactslist = new List<Contact>();
            var excel = new ExcelQueryFactory(@"C:\Users\Dell\Desktop\users.csv");
            string csvFile = @"C:\Users\Dell\Desktop\users.csv";
            string[] lines = File.ReadAllLines(csvFile);
            
            string[] columns = lines[0].Split('\\');
            Dictionary<string, int> d = new Dictionary<string, int>();
            d.Add("FullName", 0);
            d.Add("Company", 1);
            d.Add("Position", 2);
            d.Add("Country", 3);
            d.Add("Email", 4);
            d.Add("DataInserted", 5);

            for(int i=0;i<lines.Length;i++)
            {
                Contact contact = new Contact();
                string[] values = lines[i].Split(Path.DirectorySeparatorChar);
                for(int j=0;j<values.Length;j++)
                {
                    switch(j)
                    {
                        case 0:contact.FullName = values[d["FullName"]];
                            break;
                        case 1:
                            contact.CompanyName = values[d["Company"]];
                            break;
                        case 2:
                            contact.Position = values[d["Position"]];
                            break;
                        case 3:
                            contact.Country = values[d["Country"]];
                            break;
                        case 4:
                            contact.Email= values[d["Email"]];
                            break;
                        case 5:
                            contact.DateInserted = Convert.ToDateTime(values[d["DataInserted"]]);
                            break;
                    }
                    contact.GuID = new Guid();
                }
                contactslist.Add(contact);
            }


            foreach (var value in contactslist)
            {
                Console.WriteLine($"{value.FullName} {value.CompanyName} {value.Position} {value.Country} {value.Email} {value.DateInserted}");
            }
        }
        static void Main(string[] args)
        {

            ReadFromCsv();
        }
    }
}
