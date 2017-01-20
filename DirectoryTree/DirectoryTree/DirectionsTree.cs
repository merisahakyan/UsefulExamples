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
            {
                directories.Add(path);
                int i = 0; string s = "";
                while (path[i] == ' ')
                {
                    s = s + " ";
                    i++;
                }
                foreach (string f in Directory.GetFiles(path))
                    directories.Add(s + "   " + f);
            }
            
                foreach (string d in Directory.GetDirectories(path))
                {

                    newpath = d;
                    newpath = "   " + newpath;
                    directories.Add(newpath);
                    int i = 0; string s = "";
                    while (newpath[i] == ' ')
                    {
                        s = s + " ";
                        i++;
                    }
                    foreach (string f in Directory.GetFiles(d))
                    {
                        directories.Add(s + "   " + f);
                    }
                    GetTree(newpath);

                }
            

        }

        public static void Print()
        {
            foreach (var m in directories)
            {
                Console.WriteLine(m);
            }
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
