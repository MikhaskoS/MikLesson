using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Мое любимое окошко!";

            // размер окна

            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);
          
            Console.CursorVisible = false;

            int x = 10;
            int y = 0;

            int frequency = 37;

            while (true)
            {
                DrawChar('#', x, y);
                DrawChar('&', x + 1, y);

                //Console.Beep();
                frequency += 100;
                if (frequency > 37000) frequency = 37;
                Console.Beep(frequency, 100);

                Thread.Sleep(100);

                y = y + 1;

                Clear(x, y - 1);
                Clear(x + 1, y - 1);


                if (y ==25 )
                {
                    y = 0;
                }

            }
            
        }

        public static void DrawChar(char ch, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(ch);
        }

        public static void Clear(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(' ');
        }


    }
}
