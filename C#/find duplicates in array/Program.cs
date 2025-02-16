using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace find_duplicates_in_array
{
    class A
    {
        public static void Main()
        {
            int n, s, f = 0;
            Console.Write("Enter size of array: ");
            n = Convert.ToInt32(Console.ReadLine());
            
            int[] ar = new int[n];
            Console.WriteLine("Enter the array elements: ");
            for(int i = 0; i < n; i++)
            {
                ar[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter search item: ");
            s = Convert.ToInt32(Console.ReadLine());

            List<int> item = new List<int>();
            List<int> pos = new List<int>();

            for(int i = 0; i < n; i++)
            {
                if(ar[i] == s)
                {
                    f = 1;
                    item.Add(ar[i]);
                    pos.Add(i);
                }
            }

            if (f == 1)
            {
                Console.WriteLine("Item found.");
                for(int i = 0; i < pos.Count; i++)
                {
                    Console.WriteLine("item: {0} at position: {1}", item[i], pos[i]);
                }
            }
            else
            {
                Console.WriteLine("Item not found in the list.");
            }
            Console.ReadKey();
        }
    }
}
