using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addition
{
    class Program
    {
        public static void Main()
        {
            int a, b, sum;
            Console.Write("Enter first number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            b = Convert.ToInt32(Console.ReadLine());
            sum = a + b;
            Console.WriteLine("Sum = {0}", sum);
            Console.ReadKey();
        }
    }
}
