using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partial_class
{
    public partial class EMP
    {
        public string name { set; get; }
        public int age { set; get; }
    }

    public partial class EMP
    {
        public string address { set; get; }
        public string phone { set; get; }
    }
    class A
    {
        public static void Main()
        {
            EMP ob = new EMP();
            Console.WriteLine("Enter details of user: ");
            ob.name = Console.ReadLine();
            ob.age = Convert.ToInt32(Console.ReadLine());
            ob.address = Console.ReadLine();
            ob.phone = Console.ReadLine();

            Console.WriteLine($"Name: {ob.name}, Age: {ob.age}, Address: {ob.address}, Phone: {ob.phone}");
            Console.ReadKey();
        }
    }
}
