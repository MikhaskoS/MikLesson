using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_3
{
    class MyClass
    {
        public void Swap(ref int a,ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }

        public static void SuperSwap(ref int a, ref int b)
        {
            a = a - b;
            b = a + b;
            a = b - a;
        }

        /// <summary>
        /// сумма чисел
        /// </summary>
        /// <param name="a">коровы</param>
        /// <param name="b">овцы</param>
        /// <returns>кирпичи</returns>
        public int Sum(int a, int b)
        {
            int res = a + b;
            return res;
        }

        public string Sum(string a, string b)
        {
            string res = a + b;
            return res;
        }

        public int Sum(int a, int b, int c)
        {
            int res = a + b + c;
            return res;
        }

        public static int Factorial(int n)
        {
            int k = 0;
            int res = 1;
            while(k < n)
            {
                k++;
                res = res * k;
            }
            return res;
        }
        
        public static decimal F (decimal n)
        {
            if (n == 0) return 1;

            return n * F(n - 1);
        }
    
    }

}
