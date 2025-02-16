using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adding_two_2d_arrays
{
    class Program
    {
        public static void Main()
        {
            int r1, c1, r2, c2;
            Console.Write("Enter value of r1: ");
            r1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value of c1: ");
            c1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value of r2: ");
            r2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value of c2: ");
            c2 = Convert.ToInt32(Console.ReadLine());

            int[,] A = new int[r1, c1];
            int[,] B = new int[r2, c2];
            

            if (r1 == r2 && c1 == c2)
            {
                Console.WriteLine("Enter content of first array.");
                for (int i = 0; i < r1; i++)
                {
                    for (int j = 0; j < r2; j++)
                    {
                        A[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.WriteLine("Enter content of second array.");
                for (int i = 0; i < r2; i++)
                {
                    for (int j = 0; j < c2; j++)
                    {
                        B[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                //Adding 2 arrays.
                int[,] sum = new int[r1, c1];

                for (int i = 0; i < r1; i++)
                {
                    for (int j = 0; j < c1; j++)
                    {
                        sum[i, j] = A[i, j] + B[i, j];
                    }
                }

                Console.WriteLine("Sum  array:");

                for(int i = 0; i < r1; i++)
                {
                    for(int j = 0; j < c1; j++)
                    {
                        Console.Write(sum[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Array size are not matching.");
            }
            Console.ReadKey();
        }
    }
}
