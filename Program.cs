using System;
namespace Name
{
    class program
    {
        static int fristValue(int x, int y)
        {
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            return x + y;
        }
        static double PushMathorDauble(double x, double y)
        {
            return x + y;
        }
        public static void Main(string[] array)
        {
            int myNumber1 = fristValue(x, y);
            double myDouble = PushMathorDauble(6, 2);
            System.Console.WriteLine("Int " + myNumber1);
            System.Console.WriteLine("Dauble " + myDouble);
        }
    }
}