using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_n_prime_numbers
{
    class Program
    {
        public static void Main()
        {
            int n;
            Console.Write("Enter  value of n: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= n; i++)
            {
                int flag = 0;
                for (int j = 1; j <= i; j++)
                {
                    if(i%j == 0)
                    {
                        flag++;
                    }
                }
                if (flag == 2)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}
