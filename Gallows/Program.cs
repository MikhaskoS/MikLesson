using System;

namespace Gallows
{
    class Program
    {
        static void Main(string[] args)
        {
            string word_original = "машина";
            byte attempt = 5;
            string word = new string('*', word_original.Length);

            Console.WriteLine($"Дарова, отгадай моё слово из {word_original.Length} букв");

            while(attempt > 0)
            {
                Console.WriteLine($"Угадай букву в моём слове {word}:");
               
                ConsoleKeyInfo a = Console.ReadKey();
                char ch = a.KeyChar;
                Console.WriteLine();

                bool yes = MyFunction.CharInString(word_original, ch);
                if (yes)
                {
                    Console.WriteLine("да");
                    word = MyFunction.Replace(word_original, word, ch);
                }
                else
                {
                    Console.WriteLine("нет");
                    attempt--;
                }
            }
        }
    }
}
