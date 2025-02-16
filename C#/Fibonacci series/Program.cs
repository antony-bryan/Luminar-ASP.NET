using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_series
{
    class Program
    {
        public static void Main()
        {
            int a = 0, b = 1, c, n;
            Console.Write("Enter the value of n: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a);
            Console.WriteLine(b);

            while (3 <= n)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
                --n;
            }
            Console.ReadKey();

        }
    }
}
