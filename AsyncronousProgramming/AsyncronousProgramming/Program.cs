using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncronousProgramming
{
    class MyFirstAsync
    {
        public async void Print1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 10000; i++)
                {
                    Thread.Sleep(8);
                    Console.WriteLine("aaaaaaaaaaa");
                }
            });
            
        }
        public async void Print2()
        {
           await Task.Run(() =>
            {
                for (int i = 0; i < 10000; i++)
                {
                    //Thread.Sleep(8);
                    Console.WriteLine("bbb");
                }
            });
            
        }
        public async void Print3()
        {
           await Task.Run(() =>
            {
                for (int i = 0; i < 10000; i++)
                {
                    //Thread.Sleep(8);
                    Console.WriteLine("ccccccc");
                }
            });
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //4 threads working at the same time
            MyFirstAsync ob = new MyFirstAsync();
            ob.Print1();
            ob.Print2();
            ob.Print3();
            for (int i = 0; i < 10000; i++)
            {
                Thread.Sleep(8);
                Console.WriteLine("out");
            }
            Console.ReadLine();
        }
    }
}
