using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_n_natural_numbers
{
    class Program
    {
        public static void Main()
        {
            int n, i=1;
            Console.WriteLine("Printing n natural numbers...");
            Console.Write("Enter value of n: ");
            n = Convert.ToInt32(Console.ReadLine());

            while (i <= n)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.ReadKey();
            
        }
    }
}
