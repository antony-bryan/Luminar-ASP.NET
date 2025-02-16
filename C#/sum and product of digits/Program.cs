using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_and_product_of_digits
{
    class Program
    {
        public static void Main()
        {
            int n, sum = 0, product = 1, digit, choice;
            Console.Write(" Menu\n 1. Find sum of digits.\n 2. Find product of digits.\n Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                while (n > 0)
                {
                    digit = n % 10;
                    n /= 10;
                    sum += digit;
                }
                Console.WriteLine(sum);
            }
            else if (choice == 2)
            {
                while (n > 0)
                {
                    digit = n % 10;
                    n /= 10;
                    product *= digit;
                }
                Console.WriteLine(product);

            }
            else
            {
                Console.WriteLine("Enter valid choice.");
            }
            Console.ReadKey();

        }
    }
}
