using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_sort
{
    class Program
    {
        public static void Main()
        {
            int n, temp;
            Console.Write("Enter value of n: ");
            n = Convert.ToInt32(Console.ReadLine());
            
            int[] A = new int[n];
            Console.WriteLine("Enter array values: ");
            for(int i = 0; i < n; i++)
            {
                A[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i = 0; i < n - 1; i++)
            {
                for(int j = i+1; j < n; j++)
                {
                    if (A[i] > A[j])
                    {
                        temp = A[j];
                        A[j] = A[i];
                        A[i] = temp;
                    }
                }
            }
            for(int i = 0; i < n; i++)
            {
                Console.Write(A[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
