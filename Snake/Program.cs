using System;

namespace Snake
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int x1 = 1;
            int y1 = 3;
            char sym1 = '*';

            Draw(x1, y1, sym1);
           
            Console.ReadLine();
        }
        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
