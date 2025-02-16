using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class
{
    abstract class A
    {
        public void display()
        {
            Console.WriteLine("Abstract class display function.");
        }
        public abstract void absmethod();
    }
    class B : A
    {
        public override void absmethod()
        {
            Console.WriteLine("abstract method declaration.");
        }
        public static void Main()
        {
            B ob = new B();
            ob.display();
            ob.absmethod();
            Console.ReadKey();
        }
    }
}
