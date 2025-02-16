using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_number
{
    class Program
    {
        public static void Main()
        {
            int n, f = 0;
            Console.Write("Enter value of n: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine("1 is not defined.");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        f += 1;
                    }
                }

                if (f == 2)
                {
                    Console.WriteLine("Prime.");
                }
                else
                {
                    Console.WriteLine("Not Prime.");
                }
            }
            Console.ReadKey();
        }
    }
}
