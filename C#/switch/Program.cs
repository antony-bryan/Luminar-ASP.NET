using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
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
                    Console.WriteLine("Java");
                    break;
                case 3:
                    Console.WriteLine("Python");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
            Console.ReadKey();
        }
    }
}
