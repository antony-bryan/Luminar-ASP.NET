using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_handling_2
{
    class A
    {
        public static void Main()
        {
            try
            {
                int x, y;
                Console.WriteLine("Enter value of x and y: ");
                x = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());
                int z = x / y;
                Console.WriteLine(z);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
