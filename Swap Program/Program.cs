using System;
namespace swap
{
    class Program
    {

        public static void Main(string[] arrays)
        {
            int temp;

            System.Console.WriteLine("Enter A Number - ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Enter B Number - ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            temp = num1;
            num1 = num2;
            num2 = temp;

            System.Console.WriteLine("value of num1 and num2 is :- " + (num1, num2));
        }
    }
}