using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryTree
{
    public class DirectionsTree
    {
        static ArrayList directories = new ArrayList();
        static string newpath = String.Empty;
        public static void GetTree(string path)
        {

            if (!IsContains(directories, path.Trim()))
                directories.Add(path);
            try
            {
                foreach (string d in Directory.GetDirectories(path))
                {
                    newpath = d;
                    newpath = "   " + newpath;
                    directories.Add(newpath);
                    GetTree(newpath);

                }
            }
            catch (Exception ex)
            {
                directories.Add(ex.Message);
            }

        }

        public static void Print()
        {
            foreach (var m in directories)
                Console.WriteLine(m);
        }
        static bool IsContains(ArrayList list, string str)
        {
            bool t = false;
            foreach (string m in list)
                if (m.Contains(str))
                {
                    t = true;
                    break;
                }
            return t;
        }
    }
}
