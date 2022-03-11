using System;
namespace Cricle
{
    class Program
    {
        static void Main(string[] arrays)
        {
            double area, redious;
            System.Console.WriteLine("Enter Redious Number - ");
            redious = Convert.ToDouble(Console.ReadLine());
            area = Math.PI * redious * redious;
            System.Console.WriteLine("Area is Cricle - " + area);
            Console.ReadKey();
        }
    }
}