using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_2
{
    interface A
    {
        int sum();
    }
    class B
    {
        public int product(int x,int y)
        {
            return (x * y);
        }
    }
    class C : B,A
    {
        public int sum()
        {
            int x = 100, y = 100;
            return (x + y);
        }
        public static void Main()
        {
            int x = 4, y = 6;
            C ob = new C();
            int s = ob.sum();
            Console.WriteLine("Sum = {0}", s);
            int p = ob.product(x, y);
            Console.WriteLine("Product = {0}", p);
            Console.ReadKey();
        }
    }
}
