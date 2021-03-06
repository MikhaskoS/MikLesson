using System;
using System.Threading;


namespace Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 40;
            int height = 20;

            InitializeWindow(width, height);
            DrawFrame(width, height);


            Point p1 = new Point(20, 10, '@');
            p1.Draw();

            while (true)
            {
                if (p1.X < 1) p1.X = 1;
                if (p1.X > width - 2) p1.X = width - 2;
                if (p1.Y < 1) p1.Y = 1;
                if (p1.Y > height - 2) p1.Y = height - 2;

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.D:
                        p1.MoveRight();
                        break;
                    case ConsoleKey.S:
                        p1.MoveDown();
                        break;
                    case ConsoleKey.A:
                        p1.MoveLeft();
                        break;
                    case ConsoleKey.W:
                        p1.MoveUp();
                        break;                    
                }

                Thread.Sleep(1);
            }

        }

        /// <summary>
        /// Инициализация окна
        /// </summary>
        private static void InitializeWindow(int width, int heigth)
        {
            Console.Title = "Game";

            // размер окна

            Console.SetWindowSize(width, heigth);
            Console.SetBufferSize(width, heigth);

            Console.CursorVisible = false;
        }

        private static void DrawFrame(int width, int heigth)
        {
            for (int j = 0; j < heigth; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    if (j == 1 || j == heigth -1)
                    {
                        Console.SetCursorPosition(i, j);
                        Console.Write('.');
                    }
                }
            }
        }
    }
}
