using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticFraction
{
    public class Fraction
    {
        private int _numerator;
        private int _denomenator;

        public int Numerator { get => _numerator; set => _numerator = value; }
        public int Denomenator { get => _denomenator; set => _denomenator = value; }

        /// <summary>
        /// конструктор дроби
        /// </summary>
        /// <param name="numerator">числитель</param>
        /// <param name="denomenator">знаменатель</param>
        public Fraction(int numerator, int denomenator)
        {
            Numerator = numerator;
            _denomenator = denomenator;
        }


        private int NOD(int a, int b)
        {
            if (a < b)
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

        /// <summary>
        /// сократить дробь 
        /// </summary>
        public void Reduction()
        {
            int nod = NOD(Numerator, _denomenator);
            if (nod == 1) return;

            Numerator = Numerator / nod;
            _denomenator = _denomenator / nod;
        }

        public void Flip()
        {
            int t = Numerator;
            Numerator = _denomenator;
            _denomenator = t;
        }


        public void Print()
        {
            Console.WriteLine($"{Numerator}/{_denomenator}");
        }
        public void PrintCorrect()
        {
            if (_denomenator > Numerator) Print();
            else
            {
                int a = Numerator / _denomenator;
                int n = Numerator % _denomenator;
                if (n == 0) 
                    Console.WriteLine($"{a}");
                else 
                    Console.WriteLine($"{a}_{n}/{_denomenator}");
            }
        }

        static public Fraction Add(Fraction f1, Fraction f2)
        {
            int n = f1.Numerator * f2.Denomenator + f1.Denomenator * f2.Numerator;
            int t = f1.Denomenator * f2.Denomenator;

            Fraction res = new Fraction(n, t);
            res.Reduction();

            return res;
        }
    }
}
