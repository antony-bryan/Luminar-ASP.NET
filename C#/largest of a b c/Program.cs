using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace largest_of_a_b_c
{
    class Program
    {
        public static void Main()
        {
            int a, b, c;
            Console.WriteLine("Enter value of a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of c: ");
            c = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("{0} is largest number.", a);
                }
                else
                {
                    Console.WriteLine("{0} is largest number.", c);
                }
            }
            else if (b > c)
            {
                Console.WriteLine("{0} is largest number.", b);
            }
            else
            {
                Console.WriteLine("{0} is largest number.", c);
            }
            Console.ReadKey();
        }
    }
}
