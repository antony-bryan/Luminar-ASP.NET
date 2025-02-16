using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automatic_property
{
    class A
    {
        public int P1 { set; get; }
    }
    class B
    {
        public static void Main()
        {
            A ob = new A();
            ob.P1 = 5;
            Console.WriteLine($"value of x = {ob.P1}");
            Console.ReadKey();
        }
    }
}
