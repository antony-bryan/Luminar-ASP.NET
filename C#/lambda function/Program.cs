using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda_function
{
    class A
    {
        public static void Main()
        {
            int[] numbers = { 36, 71, 12, 15, 29, 18, 27, 17, 9, 34 };

            //a,b => a + b;

            var square = numbers.Select(x => x * x);
            Console.Write("Squares list; ");
            foreach(var value in square)
            {
                Console.Write("{0} ", value);
            }
            Console.ReadKey();
        }
    }
}
