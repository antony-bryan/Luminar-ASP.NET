﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ans1_final_final
{
    public class A
    {
        public int Num1 { set; get; }
        public int Num2 { set; get; }
        public int Num3 { set; get; }
    }
    public interface B
    {
        void get_input();
    }
    public class C : A, B
    {
        public void get_input()
        {
            C ob = new C();
            Console.Write("Enter 1st number: ");
            ob.Num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd number: ");
            ob.Num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 3rd number: ");
            ob.Num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Product = {0}", ob.Num1 * ob.Num2 * ob.Num3);
        }
        
        public static void Main()
        {
            C ob = new C();
            ob.get_input();
            Console.ReadKey();
        }
    }
}
