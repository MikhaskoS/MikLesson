using System;
using System.Threading;


namespace Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Game";

            // размер окна

            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            Console.CursorVisible = false;

            while (true)
            {
                //--------------------

                //--------------------

                Point P1 = new Point(40, 12, '!');
                P1.Draw();
                Point P2 = new Point(50, 12, '$');
                P2.Draw();

                Rectangle R1 = new Rectangle(9, 10, 5, 5, '#');
                R1.Draw();
                Rectangle R2 = new Rectangle(20, 15, 10, 10, '$');
                R2.Draw();


                Thread.Sleep(100);
            }


        }
      
    }
}
