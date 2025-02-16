using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace output_parameter
{
    class A
    {
        public int display(int a, out int b)
        {
            a = a + 10;
            b = a + 10;
            return a;

        }

        public static void Main()
        {
            int a = 10, b;
            A obj = new A();
            int c = obj.display(a,out b);
            Console.WriteLine("a = {0}, b = {1}", c,b);
            Console.ReadKey();
        }
    }
}
