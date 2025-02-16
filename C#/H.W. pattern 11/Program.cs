using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.W.patter_10
{
    class Program
    {
        public static void Main()
        {
            int n, temp;
            Console.Write("Ener value of n: ");
            n = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                for(int j = 1; j <=n-i; j++)
                {
                    Console.Write(" ");
                }
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                for(int j = i-1; j >= 1; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for(int i = 1; i <= n; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for(int j=i; j <= n-1; j++)
                {
                    Console.Write("*");
                }
                for(int j = n-2; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
