using System;

namespace lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] A = { 9223372036854775807, 5980, 5465, 685474 };
            long[] B = { 18, 12, 19, 8 };
   
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine(A[i] * B[i]);
            }


        }


    }
}
