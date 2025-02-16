using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read_Write_Property
{
    class A
    {
        private int x;

        public int P1
        {
            set
            {
                x = value;
            }
            get
            {
                return x;
            }
        }
    }
    class B
    {
        public static void Main()
        {
            A ob = new A();
            ob.P1 = 5;//set value
            Console.WriteLine($"value of x = {ob.P1}");//get value
            Console.ReadKey();
        }
    }
}
