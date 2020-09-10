using System;


namespace seperating_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int b;

            Console.WriteLine("enter an integer: (up to 99999)");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a divider: (up to 99999)");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("integer part of the number: " + findQuotient(number, b));
            Console.WriteLine("remainder part of the number: " + findRemainder(number, b));
            Display(number);
        }
        static int findQuotient(int num, int dividedBy)
        {
            return num / dividedBy;
        }
        static int findRemainder(int num, int dividedBy)
        {
            return num % dividedBy;
        }
        static void Display(int num)
        {
            int divisor = 10;

            if(num>=10)
            {
                Display(num / 10);
            }
            Console.Write("{0}  ", findRemainder(num,divisor));
        }
        
    }
}
