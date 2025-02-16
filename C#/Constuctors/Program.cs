using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constuctors
{
    class A
    {
        public A()
        {
            Console.WriteLine("Deafault constructor.");
        }
        public A(int a, int b)
        {
            Console.WriteLine("Sum = {0}", a + b);
        }
        static A()
        {
            Console.WriteLine("Static constructor.");
        }
        public static void Main()
        {
            //A ob = new A();
            //A obj = new A(2, 3);
            Console.ReadKey();
        }
    }
}