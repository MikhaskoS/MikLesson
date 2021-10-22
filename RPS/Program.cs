using System;

namespace RPS
{
    enum RPS {Rock, Paper,Scissors}
    

    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();


            int score_gamer = 0;
            int score_bot = 0;
            int max_score = 5;
            RPS gamer = RPS.Paper;
            RPS bot = RPS.Paper;

            gamer = RPS.Scissors;

            Console.WriteLine((int)gamer);

            while (score_gamer < max_score && score_bot < max_score)
            {
                Console.Clear();
                Console.WriteLine($"вы выбрали {gamer},а компьютер {bot}");
                Console.WriteLine($"счёт: комп - {score_bot} игрок - {score_gamer}");
                Console.WriteLine("Камень [0], Бумага[1], Ножницы[2]!:");
                ConsoleKeyInfo a = Console.ReadKey(true);
                char ch = a.KeyChar;
                if (ch == '0')
                {
                    gamer = RPS.Rock;
                }
                else if (ch == '1')
                {
                    gamer = RPS.Paper;
                }
                else if (ch == '2')
                {
                    gamer = RPS.Scissors;
                }
                else
                {
                    Console.WriteLine("Ошибка!");
                    continue;
                }

                int b = rnd.Next(0, 3);
                if (b == 0)
                {
                    bot = RPS.Rock;
                }
                else if (b == 1)
                {
                    bot = RPS.Paper;
                }
                else if (b == 2)
                {
                    bot = RPS.Scissors;
                }

                //--------------------

                if (gamer == RPS.Rock)
                {
                    if (bot == RPS.Scissors) score_gamer++;
                    if (bot == RPS.Paper) score_bot++;
                }
                
                else if (gamer == RPS.Scissors)
                {
                    if (bot == RPS.Rock) score_bot++;
                    if (bot == RPS.Paper) score_gamer++;
                }

                else if (gamer == RPS.Paper)
                {
                    if (bot == RPS.Scissors) score_bot++;
                    if (bot == RPS.Rock) score_gamer++;
                }

            }


            if (score_bot > score_gamer)
                Console.WriteLine("SO EZ BOT!");
            else
                Console.WriteLine();

            Console.Read();

        }
    }
}
