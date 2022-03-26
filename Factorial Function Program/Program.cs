using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiple_factorials
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput;
            System.Console.WriteLine("Factorials Number");
            System.Console.WriteLine("=====================");
            System.Console.WriteLine("Enter Number");
            userInput = Convert.ToInt32(Console.ReadLine());

            int num = 1;

            for (int i = userInput ; i >=1; i--)
            {
                num = num * i;
            }
            System.Console.WriteLine("Factoral Number :- " + num);






            /*
            while (num > 0)
            {
                n = num;
                for (int i = n - 1; i > 0; i--)
                {
                    n = n * i;
                }
                num--;
                System.Console.WriteLine("factorials {0} = {1}", num, n);

            }
            */
        }
    }
}