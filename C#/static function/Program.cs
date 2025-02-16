using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_function
{
    class Program
    {
        public static void sfunction()
        {
            Console.WriteLine("static function");
        }
        public static void Main()
        {
            sfunction();
            Console.ReadKey();
        }
    }
}
