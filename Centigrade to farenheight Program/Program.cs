using System;
namespace Centigrade
{
    class Program
    {

        public static void Main(string[] arrays)
        {
            int number, centigrade;
            System.Console.WriteLine("Enter Fahrenheit temperature: ");
            number = Convert.ToInt32(Console.ReadLine());

            centigrade = ((number - 32) * 5) / 9;

            System.Console.WriteLine("Centigrade value is:- " + centigrade);
        }
    }
}