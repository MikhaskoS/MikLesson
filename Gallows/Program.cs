using System;

namespace Gallows
{
    class Program
    {
        static void Main(string[] args)
        {
            string word_original = "превысокомногорассмотрительствующий";
            word_original = word_original.ToUpper();
            
            byte attempt = 0;
            string word = new string('*', word_original.Length);

            Console.WriteLine($"Дарова, отгадай моё слово из {word_original.Length} букв.");
            Console.WriteLine("Готов?");
            if (Console.ReadKey(true).Key != ConsoleKey.Y)
            { 
                attempt = 10; 
            }

            while(attempt < 5)
            {
                Console.Clear();
                Console.WriteLine($"Угадай букву в моём слове {word}:");
               
                ConsoleKeyInfo a = Console.ReadKey(true);
                char ch = a.KeyChar;
                ch = Char.ToUpper(ch);
                
                Console.WriteLine();

                bool yes = MyFunction.CharInString(word_original, ch);
                if (yes)
                {
                    Console.WriteLine("да");
                    word = MyFunction.Replace(word_original, word, ch);
                    bool game_over = MyFunction.IsGameOver(word);
                    if (game_over)
                    {
                        Console.WriteLine("Ти выиграл, уря!");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("нет");
                    attempt++;
                    MyFunction.Skeleton(attempt);
                    if (attempt == 5)
                    {
                        Console.WriteLine("Ти проиграл, попуск!");
                    }
                    Console.ReadLine();
                }

               
            }
        }
    }
}
