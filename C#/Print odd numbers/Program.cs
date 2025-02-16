// Method 1: Using % operation.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_odd_numbers
{
    class Program
    {
        public static void Main()
        {
            int n, i = 1;
            Console.WriteLine("Printing n odd numbers");
            Console.Write("Enter the value of n: ");
            n = Convert.ToInt32(Console.ReadLine());

            do
            {
               if (i%2 == 1)
                {
                    Console.WriteLine(i);
                }
                i++;
            } 
            while (i <= n);
            Console.ReadKey();
        }
    }
}
