using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multicast_delegates
{
    public delegate void del(int x, int y);

    public class A
    {
        public void sum(int a, int b)
        {
            Console.WriteLine("Sum = {0}", a + b);
        }
        public void product(int a, int b)
        {
            Console.WriteLine("product = {0}", a * b);
        }
        public static void Main()
        {
            A ob = new A();
            del d = new del(ob.sum);
            d += new del(ob.product);
            d(10, 20);
            Console.ReadKey();
        }
    }
}
