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
        static void ParseToExcel(string path, byte[] bytes)
        {
            System.IO.File.WriteAllBytes(path, bytes);
        }
        static byte[] GetActiveWorkbook(Microsoft.Office.Interop.Excel.Application app)
        {
            string path = Path.GetTempFileName();
            try
            {
                app.ActiveWorkbook.SaveCopyAs(path);
                return File.ReadAllBytes(path);
            }
            finally
            {
                if (File.Exists(path))
                    File.Delete(path);
            }
        }
        static void Main(string[] args)
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
    }
}
