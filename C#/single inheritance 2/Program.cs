using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace single_inheritance_2
{
    class A
    {
        public int a, b;
        public void read()
        {
            Console.Write("Enter value of a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value of b: ");
            b = Convert.ToInt32(Console.ReadLine());
        }
    }
    class B : A
    {
        public void sum()
        {
            Console.WriteLine("Sum = {0}", a + b);
        }
        public static void Main()
        {
            B ob = new B();
            ob.read();
            ob.sum();
            Console.ReadKey();
        }
    }
}
