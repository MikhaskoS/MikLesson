using System;

namespace Demo3
{
    public class Point
    {
        // поля
        public int X;
        public int Y;
        public char Symbol;
        public int Speed;

        // конструктор
        public Point(int x, int y, char symbol)
        {
            X = x;
            Y = y;
            Symbol = symbol;
        }

        // методы
        public void Draw() 
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(Symbol);
        }

        public void Clear()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(' ');
        }

        public void MoveRight()
        {
            Clear();
            X++;
            Console.SetCursorPosition(X, Y);
            Console.Write(Symbol);
        }

        public void MoveLeft()
        {
            Clear();
            X--;
            Console.SetCursorPosition(X, Y);
            Console.Write(Symbol);

        }

        public void MoveUp()
        {
            Clear();
            Y--;
            Console.SetCursorPosition(X, Y);
            Console.Write(Symbol);
        }

        public void MoveDown()
        {
            Clear();
            Y++;
            Console.SetCursorPosition(X, Y);
            Console.Write(Symbol);
        }
    }

}
