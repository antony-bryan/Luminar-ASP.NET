using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapping_with_only_two_variables
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
            Console.WriteLine("Before swapping: a = {0}, b = {1}", a, b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("After swapping: a = {0}, b = {1}", a, b);
            Console.ReadKey();

        }
    }
}
