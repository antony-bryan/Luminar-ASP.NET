using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_5
{
    class Porgram
    {
        public static void Main()
        {
            int n, x = 65;
            Console.Write("Enter value of n: ");
            n = Convert.ToInt32(Console.ReadLine());

            for(int i=1; i <= n; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write((char)x + "  ");
                    x++;
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
