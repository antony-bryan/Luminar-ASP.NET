using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_1
{
    class Program
    {
        public  static void Main()
        {
            int n;
            Console.Write("Enter mark: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("{0} is invalid", n);
            }
            else if (n >= 0 && n < 10)
            {
                Console.WriteLine("{0} is between 0 and 10.",n);
            }
            else if (n < 100)
            {
                Console.WriteLine("{0} is bewtween 10 and 100.", n);
            }
            else if (n < 1000)
            {
                Console.WriteLine("{0} is between 100 and 1000.", n);
            }

            Console.ReadKey();
        }
    }
}
