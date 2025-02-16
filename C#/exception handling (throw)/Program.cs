using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_handling__throw_
{
    class A
    {
        public static void Main()
        {
            try
            {
                int age;
                Console.Write("Enter age: ");
                age = Convert.ToInt32(Console.ReadLine());
                if(age < 0)
                {
                    throw new ArgumentException("Age cannot be a negative value.");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
