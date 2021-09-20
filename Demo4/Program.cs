using System;

namespace Demo4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            
            int lenght = 10;
            int[] array = new int[lenght];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 1000);
            }


            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]); 
            }


            int max = array[0];
            int min = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                int a = array[i];
                if (max < a)
                {
                    max = a;
                }

                if (min > a)
                {
                    min = a;
                }
            }

            Console.WriteLine($"max = {max}");
            Console.WriteLine($"min = {min}" );
        }

    }
}
