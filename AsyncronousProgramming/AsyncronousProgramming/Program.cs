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
        public async Task Print1()
        {
            throw new OutOfMemoryException();
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Thread.Sleep(8);
                    Console.WriteLine("aaaaaaaaaaa");
                }
            });

        }
        public async Task Print2()
        {
            await Task.Run(() =>
             {
                 for (int i = 0; i < 100; i++)
                 {
                     //Thread.Sleep(8);
                     Console.WriteLine("bbb");
                 }
             });

        }
        public async Task Print3()
        {
            await Task.Run(() =>
             {
                 for (int i = 0; i < 100; i++)
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
            var task1 = ob.Print1();
            var task2 = ob.Print2();
            var task3 = ob.Print3();
            task1.ContinueWith(t =>
            {
                if (t.IsFaulted)
                    Console.WriteLine("task is faulted!!~~~~~~~~~~~~~~~");
                else
                    for (int i = 0; i < 100; i++)
                    {
                        Thread.Sleep(8);
                        Console.WriteLine("out");
                    }
            });
            Console.WriteLine("before WhenAll");
            Task task=Task.WhenAll(task1, task2, task3);
            Console.WriteLine("After WhenAll");

            Console.ReadLine();
        }
    }
}
