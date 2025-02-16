using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threading
{
    class A
    {
        public static void Main()
        {
            Thread ob = new Thread(new ThreadStart(run));
            ob.Start();
            Console.ReadKey();
        }

        public static void run()
        {
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
