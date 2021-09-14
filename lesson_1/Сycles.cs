using System;


namespace lesson_1
{
    class Сycles
    {
        /// <summary> Описание функции. Ля-ля. </summary>
        public static void Printer()
        {
            Console.WriteLine("Функция Printer!");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i} ");
            }


            int k = 0;
            while (k < 100)
            {
                k++;
                Console.Write($"{k} ");
            }

            Console.WriteLine();

            int n = 0;
            do
            {
                n++;
                Console.Write($"{n} ");
               
            } while (n < 100);

            Console.WriteLine();

            string str = "Мища!";

            foreach (char ch in str)
                Console.WriteLine(ch);
        }
    }
}
