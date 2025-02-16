using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting_digits
{
    class Program
    {
        public static void Main()
        {
            int n, count = 0, temp;
            Console.WriteLine("Enter value of n: ");
            n = Convert.ToInt32(Console.ReadLine());
            temp = n;

            while (n > 0)
            {
                n /= 10;
                count++;
            }

            Console.WriteLine("{0} has {1} digits.", temp, count);
            Console.ReadKey();
        }
    }
}
