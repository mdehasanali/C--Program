using System;
namespace Smallest
{
    class Program
    {
        static void Main(string[] arrays)
        {
            int first, secend, thrid;

            System.Console.WriteLine("Enter the First Number");
            first = Convert.ToInt32(System.Console.ReadLine());

            System.Console.WriteLine("Enter the secend Number");
            secend = Convert.ToInt32(System.Console.ReadLine());

            System.Console.WriteLine("Enter the thrid Number");
            thrid = Convert.ToInt32(System.Console.ReadLine());

            if (first < secend)
            {
                if (first < thrid)
                {
                    System.Console.WriteLine("The Smallest Number - " + first);
                }
                else
                {
                    System.Console.WriteLine("The Smallest Number - " + thrid);
                }
            }

            else
            {
                if (secend < thrid)
                {
                    System.Console.WriteLine("The Smallest Number - " + secend);
                }
                else
                {
                    System.Console.WriteLine("The Smallest Number - " + thrid);
                }
            }
            Console.WriteLine("The Program is End");
        }
    }
}