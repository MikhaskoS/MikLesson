using System;

namespace lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("введи 2 числа");
            //string a_string = Console.ReadLine();
            //string b_string = Console.ReadLine();

            //int a = int.Parse(a_string);
            //int b = int.Parse(b_string);


            //int nod = NOD(a, b);

            //Console.WriteLine($"вы ввели {a_string} и {b_string}");
            //Console.WriteLine($"НОД = {nod}");

            for (uint i = 1; i <= 4294967295; i++)
            {
                if (IsSimple(i))
                    Console.WriteLine(i);
            }

        }


        public static int NOD(int a, int b)
        {
            if (a<b)
            {
                int temp = a;
                a = b;
                b = temp;
            }

            int nod = 0;
            int r = -1;

            while (r != 0)
            {
                int n = a / b;
                r = a % b;

                if (r == 0)
                {
                    nod = b;
                }
                else
                {
                    a = b;
                    b = r;
                }
            }

            return nod;
        }

        public static bool IsSimple(uint a)
        {
            for (uint i = 2; i <= a - 1; i++)
            {
                if (a % i == 0) return false;
            }

            return true;
        }
    }

}
