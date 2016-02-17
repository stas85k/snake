using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            HorizontalLine lineH1 = new HorizontalLine(5, 20, 8, '+');
            lineH1.Drow();
            HorizontalLine lineH2 = new HorizontalLine(5, 20, 16, '+');
            lineH2.Drow();
            VerticalLine lineV1 = new VerticalLine(8, 16, 5, '+');
            lineV1.Drow();
            VerticalLine lineV2 = new VerticalLine(8, 16, 20, '+');
            lineV2.Drow();

            Console.ReadLine();
        }
    }
}
