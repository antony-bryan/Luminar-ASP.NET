using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @delegate
{
    public delegate int del(int a, int b);

    class A
    {
        public int sum(int x, int y)
        {
            return (x + y);
        }
        public static void Main()
        {
            A ob = new A();
            del d = new del(ob.sum);
            int s = d(10, 20);
            Console.WriteLine("Sum = {0}",s);
            Console.ReadKey();
        }
    }
}
