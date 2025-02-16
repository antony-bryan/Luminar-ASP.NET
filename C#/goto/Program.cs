using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @goto
{
    class Program
    {
        public static void Main()
        {
            int n;
            Console.Write("Enter value of n: ");
            n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.WriteLine("C#");
                    break;
                case 2:
                    Console.Write("java");
                    break;
                case 3:
                    Console.WriteLine("Python");
                    goto case 2;
                default:
                    Console.WriteLine("Invaild");
                    break;
            }
            Console.ReadKey();
        }
    }
}
