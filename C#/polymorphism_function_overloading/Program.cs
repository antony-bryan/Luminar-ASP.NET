using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_function_overloading
{
    class A
    {
        public void sum()
        {
            int x = 2, y = 7;
            Console.WriteLine("Sum = {0}", (x + y));
        }
        public int sum(int x,int y)
        {
            return (x + y);

        }
        public double sum(double d1, double d2)
        {
            return (d1 + d2);
        }
        public static void Main()
        {
            int x = 3, y = 8;
            double d1 = 25.3, d2 = 2.5;
            A ob = new A();
            ob.sum();
            int s = ob.sum(x, y);
            Console.WriteLine("sum = {0}",s);
            double s1 = ob.sum(d1, d2);
            Console.WriteLine("Sum = {0}", s1);
            Console.ReadKey();
        }
    }
}
