﻿using System;

namespace Greatet_Common_Divisor
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            Console.WriteLine("Enter two integers:");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Greatest Common Divisor is:  " + GCD(num1, num2));
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
        static public int GCD(int a, int b)
        {
            if (a == 0)
                return b;
            if (b == 0)
                return a;

            if (a > b)
                return GCD(a % b, b);
            else
                return GCD(a, b % a);
        }
       
    }

}
