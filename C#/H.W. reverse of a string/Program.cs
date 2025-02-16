using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.W.reverse_of_a_string
{
    class A
    {
        public static void Main()
        {
            string s, rev = "";
            Console.Write("Enter a string: ");
            s = Console.ReadLine();
            
            for(int i = s.Length - 1; i >= 0; i--)
            {
                rev = rev + s[i];
            }
            Console.WriteLine("Reverse :{0}",rev);
            Console.ReadKey();
        }
    }
}
