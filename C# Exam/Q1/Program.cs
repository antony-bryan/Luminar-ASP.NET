using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    interface A
    {
        int num1 { set; get; }
        int num2 { set; get; }
        int num3 { set; get; }
    }
    interface B
    {
        void get_input();
        int product();
    }
    public class C : A, B
    {
        public void get_input()
        {
            C ob = new C();
            Console.Write("Enter 1st number: ");
            ob.num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd number: ");
            ob.num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 3rd number: ");
            ob.num3 = Convert.ToInt32(Console.ReadLine());
        }
        public int product()
        {
            C ob = new C();
            int p = ob.num1 * ob.num2 * ob.num3;
            return p;
        }
        public static void Main()
        {
            C ob = new C();
            ob.get_input();
            Console.WriteLine("Product = {0}", ob.product());
            Console.ReadKey();
        }
    }
}
