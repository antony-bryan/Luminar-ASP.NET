using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function_overrding
{
    class A
    {
        public virtual void display()
        {
            Console.WriteLine("Inside base class.");
        }
    }
    class B : A
    {
        public override void display()
        {
            //base.display();
            Console.WriteLine("Derived class method.");
        }
        public static void Main()
        {
            B ob = new B();
            ob.display();
            Console.ReadKey();
        }
    }
}
