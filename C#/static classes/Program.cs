using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_classes
{
    public static class MathsCalculator
    {
        public static int calculateMax(int[] ar)
        {
            int max = 0;
            for(int i = 0; i < ar.Length; i++)
            {
                if(ar[i] > max)
                {
                    max = ar[i];
                }
            }
            return max;
        }
        public static int calculateMin(int[] ar)
        {
            int min = ar[0];
            for(int i = 0; i < ar.Length; i++)
            {
                if(ar[i] < min)
                {
                    min = ar[i];
                }
            }
            return min;
        }
    }
    class A
    {
        public static void Main()
        {
            int[] numList = { 12, 33, 44, 53, 65, 94, 45, 88 };
            int max = MathsCalculator.calculateMax(numList);
            int min = MathsCalculator.calculateMin(numList);
            Console.WriteLine($"Max number: {max}");
            Console.WriteLine($"Min number: {min}");
            Console.ReadKey();
        }
    }
}
