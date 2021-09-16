using System;

namespace Demo2
{
    public class Point
    {
        public int X;
        public int Y;
        public char Symbol;

        // конструктор
        public Point(int x, int y, char symbol)
        {
            X = x;
            Y = y;
            Symbol = symbol;
        }

        public void Draw() 
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(Symbol);
        }
    }
}
