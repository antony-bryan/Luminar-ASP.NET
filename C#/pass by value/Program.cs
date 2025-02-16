using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pass_by_value
{
    class A
    {
        public void display(int x)
        {
            x += 10;
            Console.WriteLine("Inside the function x = {0}", x);
        }

        public static void Main()
        {
            int x = 10;
            A obj = new A();
            obj.display(x);
            Console.WriteLine("Inside the Main function x = {0}", x);
            Console.ReadKey();
        }
    }
}
