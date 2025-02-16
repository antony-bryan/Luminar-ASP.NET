using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_an_array
{
    class Program
    {
        public static void Main()
        {
            int n, sum = 0;
            Console.Write("Enter lenght of an array: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] A = new int[n];

            Console.WriteLine("Enter elements of the array: ");

            for(int i = 0; i < n; i++)
            {
                A[i] = Convert.ToInt32(Console.ReadLine());
                sum += A[i];
            }

            Console.WriteLine("sum = {0}", sum);
            Console.ReadKey();
        }
    }
}
