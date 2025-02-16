using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reading_input
{
    class Program
    {
        public static void Main()
        {
            string name;
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("your name is {0}", name);
            Console.ReadKey();
        }
    }
}
