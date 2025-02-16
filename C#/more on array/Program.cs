using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace more_on_array
{
    class Program
    {
        public static void Main()
        {
            int n, flag = 0, pos = 0, se;
            Console.WriteLine("Enter length of array: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] A = new int[n];

            Console.WriteLine("Enter elements of the array: ");
            for(int i = 0; i < n; i++)
            {
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter serach element to be searched: ");
            se = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                if(A[i] == se)
                {
                    flag++;
                    pos = i;
                }
            }
            if (flag > 0)
            {
                Console.WriteLine("{0} Found at position {1}, {2} many times", se, pos, flag);
            }
            else
            {
                Console.WriteLine("{0} not found in array.", se);
            }
            Console.ReadKey();
        }
    }
}
