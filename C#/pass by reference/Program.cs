using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pass_by_reference
{
    class A
    {
        public void display(ref int x)
        {
            x += 10;
            Console.WriteLine("inside funtion x = {0}", x);
        }
        public static void Main()
        {
            int x = 10;
            A obj = new A();
            obj.display(ref x);
            Console.WriteLine("inside Main functoin x = {0}", x);
            Console.ReadKey();
        }
    }
}
