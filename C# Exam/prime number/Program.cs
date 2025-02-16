using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_number
{
    public abstract class A
    {
        public abstract void prime();
    }
    public class B : A
    {
        public override void prime()
        {
            int n;
            Console.Write("Enter value of n: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= n; i++)
            {
                int flag = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        flag++;
                    }
                }
                if (flag == 2)
                {
                    Console.Write("{0} ", i);
                }
            }
        }
        public static void Main()
        {
            B obj = new B();
            obj.prime();
            Console.ReadKey();
        }
    }
}
