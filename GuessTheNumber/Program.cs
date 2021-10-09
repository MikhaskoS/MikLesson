using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 0;
            int max = 100;
            bool gameOver = false;
            int counter = 0;

            Random rnd = new Random();
            int number = rnd.Next(min, max);
            Console.WriteLine(number);

            do
            {
                counter++;

                Console.WriteLine($"Угадай число от {min} до {max}:");
                string s = Console.ReadLine();
                int n = int.Parse(s);

                if (n>number)
                {
                    Console.WriteLine("Моё число меньше!");
                    
                }
                else if (n<number)
                {
                    Console.WriteLine("Моё число больше!");

                }
                else
                {
                    Console.WriteLine("Молодец, точно в цель!");
                    gameOver = true;
                    Console.WriteLine($"Количество попиток {counter} ");
                    Console.WriteLine("Хочешь ещё раз сыграть?");
                   if(Console.ReadKey().Key== ConsoleKey.Y)
                    {
                        gameOver = false;
                        counter = 0;
                        number = rnd.Next(min, max);
                    }

                }
             
 
            }
            while (gameOver == false);
        }
    }
}
