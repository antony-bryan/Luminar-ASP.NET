using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print_words_of_a_string
{
    class A
    {
        public static void Main()
        {
            string s;
            Console.Write("Enter string: ");
            s = Console.ReadLine();

            string[] words = s.Split();

            for(int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
            Console.WriteLine();
            foreach(string j in words)
            {
                Console.WriteLine(j);
            }
            Console.ReadKey();
        }
    }
}
