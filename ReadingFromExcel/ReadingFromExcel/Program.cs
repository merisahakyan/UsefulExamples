﻿using System;
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
        public static int MimeSampleSize = 256;

        public static string DefaultMimeType = "application/octet-stream";

        [DllImport(@"urlmon.dll", CharSet = CharSet.Auto)]
        private extern static uint FindMimeFromData(
            uint pBC,
            [MarshalAs(UnmanagedType.LPStr)] string pwzUrl,
            [MarshalAs(UnmanagedType.LPArray)] byte[] pBuffer,
            uint cbSize,
            [MarshalAs(UnmanagedType.LPStr)] string pwzMimeProposed,
            uint dwMimeFlags,
            out uint ppwzMimeOut,
            uint dwReserverd
        );
        public static string GetMimeFromBytes(byte[] data)
        {
            try
            {
                uint mimeType;
                FindMimeFromData(0, null, data, (uint)MimeSampleSize, null, 0, out mimeType, 0);

                var mimePointer = new IntPtr(mimeType);
                var mime = Marshal.PtrToStringUni(mimePointer);
                Marshal.FreeCoTaskMem(mimePointer);

                return mime ?? DefaultMimeType;
            }
            catch
            {
                return DefaultMimeType;
            }
        }
        public static List<Contact> ReadFromExcel(byte[] bytes)
        {
            List<Contact> contactslist = new List<Contact>();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "file.xlsx";
            try
            {
                File.WriteAllBytes(path, bytes);
                ExcelQueryFactory excel = new ExcelQueryFactory(path);
                var sheets = excel.GetWorksheetNames();
                var contacts = (from c in excel.Worksheet<Row>(sheets.First())
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
                File.Delete(path);
            }
            catch
            {
                File.Delete(path);
            }
            return contactslist;
        }


        public static List<Contact> ReadFromCsv(byte[] bytes)
        {
            List<Contact> contactslist = new List<Contact>();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "file.csv";
            try
            {
                File.WriteAllBytes(path, bytes);
                string[] lines = File.ReadAllLines(path);
                string[] columns = lines[0].Split(',');
                Dictionary<string, int> d = new Dictionary<string, int>();
                d.Add("FullName", 0);
                d.Add("Company", 1);
                d.Add("Position", 2);
                d.Add("Country", 3);
                d.Add("Email", 4);
                d.Add("DataInserted", 5);

                for (int i = 1; i < lines.Length; i++)
                {
                    Contact contact = new Contact();
                    string[] values = lines[i].Split(',');
                    for (int j = 0; j < values.Length; j++)
                    {
                        switch (j)
                        {
                            case 0:
                                contact.FullName = values[d["FullName"]];
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
                                contact.Email = values[d["Email"]];
                                break;
                            case 5:
                                contact.DateInserted = Convert.ToDateTime(values[d["DataInserted"]]);
                                break;
                        }
                    }
                    contact.GuID = new Guid();
                    contactslist.Add(contact);
                }
                File.Delete(path);
            }
            catch
            {
                File.Delete(path);
            }
            return contactslist;
        }
        public static List<Contact> GetContactsFromBytes(byte[] bytes)
        {
            List<Contact> list = new List<Contact>();
            string p = GetMimeFromBytes(bytes);
            switch (p)
            {
                case "text/csv":
                case "text/plain":
                    list = ReadFromCsv(bytes);
                    break;
                case "application/vnd.ms-excel":
                case "application/x-zip-compressed":
                    list = ReadFromExcel(bytes);
                    break;
                default:
                    list = null;
                    break;
            }
            return list;
        }
        static void Main(string[] args)
        {
            byte[] bytes = File.ReadAllBytes(@"C:\Users\Dell\Desktop\contacts.xlsx");

            List<Contact> contactslist = GetContactsFromBytes(bytes);

            foreach (var value in contactslist)
            {
                Console.WriteLine($"{value.FullName} {value.CompanyName} {value.Position} {value.Country} {value.Email} {value.DateInserted}");
            }
        }
    }
}