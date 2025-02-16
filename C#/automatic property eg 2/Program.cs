using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automatic_property_eg_2
{
    class A
    {
        public int num1 { set; get; }
        public int num2 { set; get; }
    }
    class B
    {
        public static void Main()
        {
            A ob = new A();
            Console.WriteLine("Enter 2 values.");
            ob.num1 = Convert.ToInt32(Console.ReadLine());
            ob.num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Sum = {ob.num1 + ob.num2}");
            Console.ReadKey();
        }
    }
}

