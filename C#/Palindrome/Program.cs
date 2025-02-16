using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        public static void Main()
        {
            int n, rem, rev = 0, temp;
            Console.WriteLine("Enter value of n: ");
            n = Convert.ToInt32(Console.ReadLine());
            temp = n;

            while (n > 0)
            {
                rem = n % 10;
                n /= 10;
                rev = rev * 10 + rem;
            }
            if (temp == rev)
            {
                Console.WriteLine("{0} is a palindrome", rev);
            }
            else
            {
                Console.WriteLine("{0} is not a palindrome.", rev);
            }
            Console.ReadKey();
        }
    }
}
