using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_number_in_given_range
{
    class Program
    {
        public static void Main()
        {
            int start, end;
            Console.Write("Enter starting range: ");
            start = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter ending range: ");
            end = Convert.ToInt32(Console.ReadLine());

            for(int j = start; j<=end; j++)
            {
                int flag = 0;
                for (int i = 1; i <= j; i++)
                {
                    if (j%i == 0)
                    {
                        flag++;
                    }
                }

                if (flag == 2)
                {
                    Console.WriteLine(j);
                }
            }
            Console.ReadKey();

        }
    }
}
