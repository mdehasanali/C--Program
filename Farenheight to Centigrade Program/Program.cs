using System;
namespace Farenheight
{
    class Program
    {

        public static void Main(string[] arrays)
        {
            int number, farenheight;
            System.Console.WriteLine("Enter Celsius temperature: ");
            number = Convert.ToInt32(Console.ReadLine());

            farenheight = ((number * 9) / 5) + 32;

            System.Console.WriteLine("Fahrenheit value is:- " + f);
        }
    }
}
