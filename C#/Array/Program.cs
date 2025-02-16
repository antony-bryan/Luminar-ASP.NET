using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        public static void Main()
        {
            int n;
            Console.Write("Enter length of array: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] A = new int[n];
            Console.WriteLine("Enter array elements: ");
            for (int i = 0; i < n; i++)
            {
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The array elements are: ");
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(A[i]);
            }
            Console.ReadKey();
        }
    }
}
