using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @break
{
    class Program
    {
        public static void Main()
        {
            for (int j = 1; j <= 5; j++)
            {


                for (int i = 1; i <= 5; i++)
                {
                    if (i == 3)
                    {
                        break;
                    }
                    Console.Write(i+ " ");
                    Console.WriteLine(j);
                }

            }
        Console.ReadKey();
        }
    }
}
