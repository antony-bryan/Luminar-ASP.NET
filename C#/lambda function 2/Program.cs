using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda_function_2
{
    class A
    {
        public static void Main()
        {
            List<int> numbers = new List<int>() { 36, 71, 12, 15, 29, 18, 27, 17, 9, 34 };
            List<int> DivBy3 = numbers.FindAll(x => (x % 3) == 0);
            Console.Write("Values divisible by 3: ");
            foreach(var value in DivBy3)
            {
                Console.Write($"{value} ");
            }
            Console.ReadKey();
        }
    }
}
