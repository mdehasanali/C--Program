using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell {

    class Program {
        public static void Main(string[] arrays) {
            int a, b, c;
            double x1, x2, d;

            Console.WriteLine("frist number a");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("secrnd number b");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("third number c");
            c = Convert.ToInt32(Console.ReadLine());

            d = b * b - 4 * a * c;

            if (d > 0) {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("The x1 Number is :- "
                    x1);
                Console.WriteLine("The x1 Number is :- "
                    x2);
            } else if (d == 0) {
                x = (-b / (2 * a))
            } else {
                Console.WriteLine("Not posiable");
            }
        }
    }
}