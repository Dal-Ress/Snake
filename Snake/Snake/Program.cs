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

            //Задаем рамку
            HorizontalLine upLine = new HorizontalLine(0, Console.WindowWidth-1, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, Console.WindowWidth-1, 28, '+');
            VerticalLine leftLine = new VerticalLine(0, 28, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 28, Console.WindowWidth-1, '+');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();

            Point p = new Point(4,5, '*');
            p.Draw();

            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();
            snake.Move();
        



            Console.ReadLine();
        }
    }
}
