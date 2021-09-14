using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int k = 1;
            //int a1 = 0;
            //int a2 = 1;

            //for (int i = 0; i < 100; i++)
            //{
            //    if (i < 2)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    else
            //    {
            //        //int a = a1 + a2;
            //        //Console.WriteLine(a);
            //        //a1 = a2;
            //        //a2 = a;

            //    }
            //}
            //Console.WriteLine("\n------------------");


            //double a = 6;
            //double b = 4;
            //Console.WriteLine(a % b);

            //int t = 4;
            //int f = t++;
            //int r = ++t;

            //Console.WriteLine($"t: {t++}");
            //Console.WriteLine($"f: {f}");
            //Console.WriteLine($"r: {r}");

            int k = 0;
            for (int i = 0; i < 1_000_000; i++) 
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    k = k + 1;   //Console.WriteLine(i);
                }
            }

            Console.WriteLine(k);
            Console.ReadLine();
        }

    }
}
