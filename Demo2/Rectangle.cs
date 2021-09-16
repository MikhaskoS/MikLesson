using System;

namespace Demo2
{
    public class Rectangle
    {
        /// <summary>
        /// координата x левого вернего угла
        /// </summary>
        public int X;
        public int Y;
        public char Symbol;
        public int Width;
        public int Heigth;

        public Rectangle(int x, int y, int width, int heigth, char symbol)
        {
            X = x;
            Y = y;
            Symbol = symbol;
            Width = width;
            Heigth = heigth;


        }

        public void Draw()
        {
            
            
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Heigth; j++)
                {
                    Console.SetCursorPosition(X + i, Y+j);
                    Console.Write(Symbol);
                }
            }
        }

    }
}
