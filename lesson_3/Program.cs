using System;

namespace lesson_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;

            Console.WriteLine($"a = {a} b = {b}"); 

            MyClass m = new MyClass();
            m.Swap(ref a, ref b);
            int res = m.Sum(a, b);

            //m.Factorial(4);



            //Console.WriteLine(MyClass.F(29));
            //Console.WriteLine($"a = {a} b = {b}");


            a = 9;
            b = 18;

            MyClass.SuperSwap(ref a, ref b);
            Console.WriteLine($"a = {a} b = {b}");
        }
    }
}
