using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{

    class A
    {
        public int P1 { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A ob = new A();
            ob.P1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ob.P1);
            Console.ReadKey();
        }
    }
}
