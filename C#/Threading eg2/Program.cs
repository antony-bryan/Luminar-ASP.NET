using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threading_eg2
{
    class A
    {
        public static void Main()
        {
            Thread obj1 = new Thread(new ThreadStart(run1));
            Thread obj2 = new Thread(new ThreadStart(run2));
            obj1.Start();
            obj2.Start();
            Console.ReadKey();
        }
        public static void run1()
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Thread1 : {0}", i);
                Thread.Sleep(1000);
            }
        }
        public static void run2()
        {
            for(int i = 10; i >= 1; i--)
            {
                Console.WriteLine("Thread2 : {0}", i);
                Thread.Sleep(1000);
            }
        }
    }
}
