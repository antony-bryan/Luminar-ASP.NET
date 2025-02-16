using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multi_level_inheritance
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
        public int s;
        public void sum()
        {
            s = x + y;
            Console.WriteLine("Sum = {0}", s);
        }
    }
    class C : B
    {
        int avg;
        public void average()
        {
            avg = s / 2;
            Console.WriteLine("Average = {0}", avg);
        }
        public static void Main()
        {
            C ob = new C();
            ob.read();
            ob.sum();
            ob.average();
            Console.ReadKey();
        }
    }

}
