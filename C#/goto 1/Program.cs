using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goto_1
{
    class Program
    {
        static void Main()
        {
        check:
            Console.Write("ENter value of n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0)
            {
                goto check;
            }
            else
            {
                Console.WriteLine("Number:{0}",n);
            }
            Console.ReadKey();
        }
    }
}
