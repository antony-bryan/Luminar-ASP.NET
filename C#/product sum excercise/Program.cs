using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product_sum_excercise
{
    class A
    {
        public int sum(int a, int b)
        {
            return a + b;
        }
        public void product(int x,int y)
        {
            Console.WriteLine("product = {0}", x*y);
        }
        public static void Main()
        {
            A obj = new A();
            int a = 10, b = 12, x = 2, y = 4, s;
            s = obj.sum(a, b);
            Console.WriteLine("Sum = {0}", s);
            obj.product(x, y);
            Console.ReadKey();
            
        }
    }
}
