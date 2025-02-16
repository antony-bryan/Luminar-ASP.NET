using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odd_or_even
{
    class Program
    {
        public static void Main()
        {
            int n;
            Console.Write("enter the value: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n%2 == 0)
            {
                Console.WriteLine("{0} is an even number.", n);
            }
            else
            {
                Console.WriteLine("{0} is an odd number.", n);
            }
            Console.ReadKey();

        }
    }
}
