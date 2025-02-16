using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        public static void Main()
        {
            int n, f = 1;
            Console.Write("Enter value of n: ");
            n = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                f = f * i;
            }
            Console.WriteLine("Factorial = {0}", f);
            Console.ReadKey();
        }
    }
}
