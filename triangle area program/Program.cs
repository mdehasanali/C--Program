using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] arrays)
        {
            double a, b, c, s, area;

            System.Console.WriteLine("Enter The First Number");
            a = Convert.ToDouble(Console.ReadLine());

            System.Console.WriteLine("Enter The Sceand Number");
            b = Convert.ToDouble(Console.ReadLine());

            System.Console.WriteLine("Enter The Thrid Number");
            c = Convert.ToDouble(Console.ReadLine());

            if ((a + b) > c && (b + c) > a && (a + c) > b)
            {
                s = (a + b + c) / 2;
                area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                Console.WriteLine("Triangle area is - " + area);
            }
            else
            {
                Console.WriteLine("Invaild Number");
            }
            System.Console.WriteLine("Triangle Program is End !");
        }
    }
}