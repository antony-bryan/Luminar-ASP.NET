using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_of_two_number
{
    class Program
    {
        public static void Main()
        {
            int a, b;
            Console.Write("Enter value of a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value of b: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("a = {0} is greater than b = {1}", a, b);
            }
            else
            {
                Console.WriteLine("b = {0} is greater than a = {1}", b, a);
            }
            Console.ReadKey();
        }
    }
}
