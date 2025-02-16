using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_3
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Enter value of n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i=1;i<=n;i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
