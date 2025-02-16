using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapping_two_variables
{
    class Program
    {
        public static void Main()
        {
            int a, b, temp;
            Console.Write("Enter the first number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before swapping:");
            Console.WriteLine("a = {0}, b = {1}", a, b);
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After swapping:");
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Console.ReadKey();
        }
    }
}
