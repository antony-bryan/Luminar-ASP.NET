using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions
{
    class Program
    {
        public void display()
        {
            Console.WriteLine("Simple function.");
        }
        public static void Main()
        {
            Program obj = new Program();
            obj.display();
            Console.ReadKey();
        }
    }
}
