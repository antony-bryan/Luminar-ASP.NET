using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial_function
{
    class Program
    {
        public int factorial()
        {
            int n, f = 1;
            Console.Write("Enter value of n: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                f = f * i; 
            }
            
            return f;
        }

        public static void Main()
        {
            Program obj = new Program();
            int f = obj.factorial();
            Console.WriteLine("Factorial = {0}", f);
            Console.ReadKey();
        }
    }
}
