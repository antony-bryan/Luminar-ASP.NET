using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_inheritance
{
    class A
    {
        public void displayA()
        {
            Console.WriteLine("Base class A.");
        }
    }
    class B:A
    {
        public void displayB()
        {
            Console.WriteLine("Derived class B.");
        }
        public static void Main()
        {
            B ob = new B();
            ob.displayA();
            ob.displayB();
            Console.ReadKey();

        }
    }
}
