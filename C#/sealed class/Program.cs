using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealed_class
{
    sealed class A
    {
        public void display()
        {
            Console.WriteLine("Inside sealed class.");
            Console.WriteLine("It cannot be inherited.");
        }
    }
    class B
    {
        public static void Main()
        {
            A ob = new A();
            ob.display();
            Console.ReadKey();
        }
    }
}
