using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = { 1, 2, 3, 4, 5, 6 };
            int l = 2, r = 4;
            int a = inputArray.Length - (r - l + 1);
            int[] arr = new int[a];
            int j = 0;
            for (int i = 0; i < inputArray.Length; i++)
                if (i > r && i < l)
                {
                    arr[j] = inputArray[i];
                    j++;
                }
            
        }
    }
}
