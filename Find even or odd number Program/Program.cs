using System;
namespace Cricle
{
    class Program
    {
        public static void Main(string[] arrays)
        {
            int number;

            System.Console.WriteLine("Enter the Number -");
            number = Convert.ToInt32(Console.ReadLine());

            if (number == 0)
            {
                System.Console.WriteLine("ZERO Number is - " + number);
            }
            else if (number % 2 == 0)
            {
                System.Console.WriteLine("The Odd Number is - " + number);
            }
            else
            {
                System.Console.WriteLine("The Even Number is - " + number);
            }
        }
    }
}