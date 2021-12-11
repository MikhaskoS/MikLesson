using System;

namespace ArithmeticFraction
{
    class Program
    {
        static void Main(string[] args)
        {

            //Fraction d1 = new Fraction(12348, 4568);

            //Console.WriteLine("Hello World!");

            //d1.Print();
            //d1.Reduction();
            //d1.Print();
            //d1.Flip();
            //d1.Print();

            //Fraction d2 = new Fraction(3568, 254);
            //d2.Reduction();
            //d2.PrintCorrect();

            Fraction d1 = new Fraction(1, 3);
            Fraction d2 = new Fraction(1, 5);

            Fraction res = Fraction.Add(d1, d2);
            res.Print();
        }
    }
}
