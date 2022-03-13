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
            int num, n;
            System.Console.WriteLine("Factorials Number");
            System.Console.WriteLine("=====================");
            System.Console.WriteLine("Enter Number");
            num = Convert.ToInt32(Console.ReadLine());

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
        }
    }
}