using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parameter_array
{
    class A
    {
        public void display(params int[] ar)
        {
            for(int i = 0; i < ar.Length; i++)
            {
                Console.Write(ar[i] + " ");
            }
            Console.WriteLine();
            foreach(int j in ar)
            {
                Console.Write(j + " ");
            }
        }
        public static void Main()
        {
            int[] ar = { 10, 20, 30, 40, 50 };
            A obj = new A();
            obj.display(ar);
            Console.ReadKey();
        }
    }
}
