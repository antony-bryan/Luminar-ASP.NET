using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse_of_a_sentence
{
    class A
    {
        public static void Main()
        {
            string s;
            Console.Write("Enter string: ");
            s = Console.ReadLine();

            string[] wrds = s.Split();

            for(int i = wrds.Length - 1; i >= 0; i--)
            {
                Console.Write(wrds[i] + ' ');
            }
            Console.ReadKey();
        }
    }
}
