using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_array
{
    class Program
    {
        public static void Main()
        {
            int r, c;
            Console.Write("Enter row size: ");
            r = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter coloumn size: ");
            c = Convert.ToInt32(Console.ReadLine());

            int[,] A = new int[r, c];

            Console.WriteLine("Enter array values: ");

            for(int i = 0; i < r; i++)
            {
                for(int j = 0; j < c; j++)
                {
                    A[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Array: ");

            for(int i = 0; i < r; i++)
            {
                for(int j = 0; j < c; j++)
                {
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
