using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negative_positive_or_zero
{
    class Program
    {
        public static void Main()
        {
            int n;
            Console.Write("Enter value: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n>0)
            {
                Console.WriteLine("{0} is a positive number.", n);
            }
            else if (n < 0)
            {
                Console.WriteLine("{0} is a negative number", n);
            }
            else
            {
                Console.WriteLine("{0} is zero", n);
            }
            Console.ReadKey();
        }
    }
}
