using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_and_product
{
    class Program
    {
        public int sum()
        {
            int a, b, s = 0;
            Console.Write("Enter value of a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value of b: ");
            b = Convert.ToInt32(Console.ReadLine());
            s = a + b;
            return s;
        }
        public void product()
        {
            int a, b, p;
            Console.Write("Enter value of a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value of b: ");
            b = Convert.ToInt32(Console.ReadLine());
            p = a * b;
            Console.WriteLine("Product = {0}", p);
        }
        public static void Main()
        {
            Program obj = new Program();
            int s = obj.sum();
            Console.WriteLine("Sum = {0}", s);
            obj.product();

            Console.ReadKey();

        }
    }
}
