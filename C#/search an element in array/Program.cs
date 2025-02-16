using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace search_an_element_in_array
{
    class Program
    {
        public static void Main()
        {
            int n, flag =0, search_value;
            Console.Write("Enter value of n: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] A = new int[n];

            Console.WriteLine("Enter elements of the array: ");
            for(int i = 0; i < n; i++)
            {
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter value to be searched: ");
            search_value = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                if(A[i] == search_value)
                {
                    flag++;
                }
            }
            if (flag > 0)
            {
                Console.WriteLine("Element found.");
            }
            else
            {
                Console.WriteLine("Element not found.");
            }
            Console.ReadKey();
        }
    }
}
