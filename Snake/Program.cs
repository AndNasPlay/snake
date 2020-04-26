using System;

namespace Snake
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(3, 6, '#');
            p2.Draw();


            Console.ReadLine();
        }
    }
}
