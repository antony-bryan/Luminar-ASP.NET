using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hierarchical_inheritance
{
    class A
    {
        public int x, y;
        public void read()
        {
            Console.Write("Enter value of x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value of y: ");
            y = Convert.ToInt32(Console.ReadLine());
        }
    }
    class B : A
    {
        public void sum()
        {
            Console.WriteLine("Sum = {0}", x + y);
        }
    }
    class C : A
    {
        public void product()
        {
            Console.WriteLine("Product = {0}", x * y);
        }
    }
    class D : A
    {   
        public void average()
        {
            int avg;
            avg = (x + y) / 2;
            Console.WriteLine("Average = {0}",avg);
        }
        public static void Main()
        {
            B objb = new B();
            C objc = new C();
            D objd = new D();

            objb.read();
            objb.sum();

            objc.read();
            objc.product();

            objd.read();
            objd.average();

            Console.ReadKey();
        }
    }
}
