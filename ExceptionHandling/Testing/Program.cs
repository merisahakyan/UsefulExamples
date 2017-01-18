using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExceptionHandling;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = @"C:\New Folder\text.txt";
            string path2 = @"C:\New Folder\cdhgcydgyhgdhghhpppppppppppppppppppppppppppppppppppppppppppphhhhhhhhhhhhhhhhhhhhhllllppppppppppppppppppppppppppppppppplllllllllllllllllllllllllllhhhhhhhhkkklllllllllllllllllkkkkkkkkkkkkkkkkkkkkhhhggggyyyyyyyyyyyyyyyyyyyytttttttttttttttttttttttttt.txt";
            HandlingInFiles.TxtReader(path1);
            HandlingInFiles.TxtReader(path2);
            for (int i = 0; i < 5; i++)
                HandlingInFiles.TxtWriter(path1);
        }
    }
}
