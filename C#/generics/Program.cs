using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
    public class gen<X, Y>
    {
        public X a { set; get; }
        public Y b { set; get; }
        public gen(X i,Y j)
        {
            a = i;
            b = j;
        }
    }

    public class A
    {
        public static void Main()
        {
            int n, m;
            Console.WriteLine("Enter value of a and b: ");
            n = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());
            
            gen<int, int> obj = new gen<int, int>(n, m);
            Console.WriteLine($"Sum = {obj.a + obj.b}");

            gen<string, string> obj1 = new gen<string, string>("Hi ", "Welcome.");
            Console.WriteLine(obj1.a + obj1.b);
            Console.ReadKey();
        }
    }
}
