using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main()
        {
            int n, rem, rev = 0;
            Console.Write("Enter value of n: ");
            n = Convert.ToInt32(Console.ReadLine());

            while (n > 0)
            {
                rem = n % 10;
                n = n / 10;
                rev = rev * 10 + rem;
            }
            Console.WriteLine("The reversed value is: {0}", rev);
            Console.ReadKey();

        }
    }
}
