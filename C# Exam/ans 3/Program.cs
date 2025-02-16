using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ans_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter value of n: ");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                if((i%3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine("three&five");
                }
                else if(i%3 == 0)
                {
                    Console.WriteLine("three");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("five");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
