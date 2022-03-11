using System;
namespace summation
{
    class Program
    {

        public static void Main(string[] arrays)

        {
            int sum = 0;
            for (int n = 1; n <= 100; n++)
            {
                sum = sum + n;
            }
            System.Console.WriteLine(sum);




            // int n = 1;
            // int sum = 0;
            // while (n <= 100)
            // {
            //     sum = sum + n;
            //     n = n + 1;
            // }
            // System.Console.WriteLine(sum);
        }
    }
}