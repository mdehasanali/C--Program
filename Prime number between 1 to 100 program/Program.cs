using System;
namespace Prime_number
{
    class Program
    {
        static void Main(string[] arrays)
        {
            System.Console.WriteLine("Prime Number between 1 and 100");
            System.Console.WriteLine("==================================");

            for (int i = 1; i < 101; i++)
            {
                int count_number = 0;
                if (i > 1)
                {
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            count_number = 1;
                            break;
                        }

                    }
                    if (count_number == 0)
                    {
                        System.Console.WriteLine(i);
                    }
                }
            }
        }
    }
}