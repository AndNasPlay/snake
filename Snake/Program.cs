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

            HorizontalLine UpLine = new HorizontalLine(0, 60, 0, '+');
            UpLine.Drow();
            HorizontalLine DownLine = new HorizontalLine(0, 60, 15, '+');
            DownLine.Drow();
            VerticalLine LeftLine = new VerticalLine(0, 15, 0, '+');
            LeftLine.Drow();
            VerticalLine RightLine = new VerticalLine(0, 15, 60, '+');
            RightLine.Drow();

            Console.ReadLine();           
        
        }
    }
}
