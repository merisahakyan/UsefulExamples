using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExceptionHandling
{
    public class HandlingInFiles
    {
        public static void TxtReader(string path)
        {
            try
            {
                using (StreamReader r = new StreamReader(path))
                {
                    string s = String.Empty;
                    while ((s = r.ReadLine()) != null)
                        Console.WriteLine(s);
                }
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("DirectoryNotFoundException");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("FileNotFoundException");
            }
            catch (PathTooLongException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("PathTooLongException");
            }
            catch (EndOfStreamException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("EndofStreaException");
            }

        }

        public static void TxtWriter(string path)
        {
            try
            {
                using (StreamWriter r = new StreamWriter(path))
                {
                    r.WriteLine(Console.ReadLine());
                }
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("DirectoryNotFoundException");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("FileNotFoundException");
                File.Create(path);
            }
            catch (PathTooLongException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("PathTooLongException");
            }
            catch (EndOfStreamException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("EndofStreaException");
            }

        }
    }
}
