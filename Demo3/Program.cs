using System;
using System.Threading;

namespace Demo3
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 80;
            int height = 20;

            Random rnd = new Random();

            InitializeWindow(width, height);
            DrawFrame(width, height);

            // массив, в котором хранятся все наши точки
            Point[] points = new Point[50];

            for (int i = 0; i < 50; i++)
            {
                Point p = new Point(rnd.Next(2,79), rnd.Next(2,19), '.');
                points[i] = p;

                points[i].Draw();
            }

            while (true)
            {
                //---------------------
                for (int i = 0; i < 50; i++)
                {
                    if (points[i].Y > height - 2) points[i].Y = 0;
                    if (points[i].X > width - 2) points[i].X = 0;
                    points[i].MoveRight();
                }
                //---------------------
                Thread.Sleep(1);
                Console.Clear();
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
                    if (j == 1 || j == heigth - 1)
                    {
                        Console.SetCursorPosition(i, j);
                        Console.Write('.');
                    }
                }
            }
        }
    }
}
