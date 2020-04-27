using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Point p1 = new Point(2, 2, '*');
            p1.Draw();
            Point p2 = new Point(2, 4, '*');
            p2.Draw();

            HorizontalLine line = new HorizontalLine(2, 20, 8, '_');
            line.Drow();

            VerticalLine Verline = new VerticalLine(8, 20, 2, '|');
            Verline.Drow();

            Console.ReadLine();           

          
        }
    }
}
