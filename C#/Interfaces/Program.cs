using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface A
    {
        int sum();
    }
    interface B
    {
        int product(int x,int y);
    }
    class C: A,B
    {
        public int sum()
        {
            int a = 100, b = 40;
            return (a + b);
        }
        public int product(int x,int y)
        {
            return (x * y);
        }
        public static void Main()
        {
            C ob = new C();
            int x = 5, y = 4;
            int s = ob.sum();
            Console.WriteLine("Sum = {0}", s);
            int p = ob.product(x, y);
            Console.WriteLine("Product = {0}", p);
            Console.ReadKey();
        }
    }
}
