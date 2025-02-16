
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_of_words_in_a_string
{
    class A
    {
        public static void Main()
        {
            string s;
            int count = 1;
            Console.Write("Enter string: ");
            s = Console.ReadLine();

            for(int i = 0; i <= s.Length-1; i++)
            {
                if (s[i] == ' ')
                {
                    count++;
                }
            }
            Console.WriteLine($"{count} words are there in the string.");
            Console.ReadKey();
        }
    }
}
