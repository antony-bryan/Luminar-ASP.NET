

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class A
    {
        public static void Main()
        {
            List<int> numbers = new List<int> { 36, 21, 12, 15, 29, 18, 27, 17, 9, 34 };
            Console.Write("The list: ");
            foreach(var value in numbers)
            {
                Console.Write("{0} ", value);
            }
            Console.ReadKey();
        }
    }
}
