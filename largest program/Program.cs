using System;

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] arrys)
        {

            int first, secend, third;
            Console.WriteLine("Inter the First number");
            first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inter the Secend number");
            secend = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inter the Thrid number");
            third = Convert.ToInt32(Console.ReadLine());

            if (first > secend && first > third)
            {
                Console.WriteLine("The Largest Number - " + first);
            }
            else if (secend > first && secend > third)
            {
                Console.WriteLine("The Largest Number - " + secend);
            }
            else
            {
                Console.WriteLine("The Largest Number - " + third);
            }
            Console.WriteLine("The Code is End");
        }
    }
}