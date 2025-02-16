using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_Multiplication
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

            if(c1 == r2)
            {
                Console.WriteLine("Enter elements of A: ");
                for(int i = 0; i < r1; i++)
                {
                    for (int j = 0; j < c1; j++)
                    {
                        A[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.WriteLine("Enter elements of B: ");
                for(int i = 0; i < r2; i++)
                {
                    for(int j = 0; j < c2; j++)
                    {
                        B[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                int[,] product = new int[r1, c2];
                
                for(int i = 0; i < r1; i++)
                {
                    for(int j = 0; j < c2; j++)
                    {
                        for(int k = 0; k < r2; k++)
                        {
                            product[i, j] = product[i, j] + A[i, k] * B[k, j];
                        }
                    }
                }
                for (int i = 0; i < r1; i++)
                {
                    for(int j = 0; j < c2; j++)
                    {
                        Console.Write(product[i,j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.Write("Matrix cannot be multiplied.");
            }
            Console.ReadKey();

        }
    }
}
