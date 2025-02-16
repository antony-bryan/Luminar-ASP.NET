using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong_number
{
    class Program
    {
        public static void Main()
        {
            int n, temp, digit, armstrong_number = 0;
            Console.WriteLine("Enter value of n: ");
            n = Convert.ToInt32(Console.ReadLine());
            temp = n;

            while (n > 0)
            {
                digit = n % 10;
                n /= 10;
                armstrong_number = armstrong_number + (digit * digit * digit);
            }

            if (armstrong_number == temp)
            {
                Console.WriteLine("{0} is an armstrong number.", armstrong_number);
            }
            else
            {
                Console.WriteLine("{0} is not an armstrong number.", armstrong_number);
            }
            Console.ReadKey();
        }
    }
}
