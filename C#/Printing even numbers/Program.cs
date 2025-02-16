using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printing_even_numbers
{
    class Program
    {
        public static void Main()
        {
            int n, i = 0;
            Console.WriteLine("Printing even numbers...");
            Console.Write("Enter value of n: ");
            n = Convert.ToInt32(Console.ReadLine());

            while (i <= n)
            {
                Console.WriteLine(i);
                i += 2;
            }
            Console.ReadKey();
        }
    }
}
