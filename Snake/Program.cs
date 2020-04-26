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
            Point p3 = new Point(2, 6, '*');
            p3.Draw();
            Point p4 = new Point(2, 8, '*');
            p4.Draw();
            Point p5 = new Point(2, 12, '*');
            p5.Draw();
            Point p6 = new Point(2, 16, '*');
            p6.Draw();

            List<int> numList = new List<int>();
            numList.Add(10);
            numList.Add(20);
            numList.Add(30);
            numList.Add(40);
            int x = numList[0];
            int y = numList[1];
            int z = numList[2];
            int j = numList[3];
            foreach (int i in numList)
            {
                Console.WriteLine(i);
            }
            numList.RemoveAt(0);

            List<char> charList = new List<char>();
            charList.Add('(');
            charList.Add('#');
            charList.Add('@');
            charList.Add('$');
            charList.Add('%');
            char a = charList[0];
            char b = charList[1];
            char c = charList[2];
            char d = charList[3];
            char e = charList[4];


            List<Point> plist = new List<Point>();
            plist.Add(p1);
            plist.Add(p2);
            plist.Add(p3);
            plist.Add(p4);
            plist.Add(p5);
            plist.Add(p6);

            Console.ReadLine();
        }
    }
}
