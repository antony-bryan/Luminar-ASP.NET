using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accepting_int_value
{
   class Program
    {
        public static void Main()
        {
            int n;
            Console.Write("Enter a number: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input is {0}", n);
            Console.ReadKey();
        }
    }
}
