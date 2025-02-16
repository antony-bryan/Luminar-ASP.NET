using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printing_odd_number_method_2
{
    class Program
    {
        public static void Main()
        {
            int n, i = 1;
            Console.WriteLine("Printing n odd numbers...");
            Console.Write("Enter value of n: ");
            n = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine(i);
                i = i + 2;
            }
            while (i <= n);
            Console.ReadKey();
        }
    }
}
