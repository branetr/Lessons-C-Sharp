using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Point
    {
        private int x;
        public int X { get { return x; } }
        private int y;
        public int Y { get { return y; } }
        string @string;
        public string @String { get { return @string; } }

        public Point(int a, int b, string @string)
        {
            this.x = a;
            this.y = b;
            this.@string = @string;
        }
    }

    class Figure
    {
        Point[] point;
        string type;

        double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow((B.Y - A.Y), 2) + Math.Pow((B.X - A.X), 2));
        }
        public void PerimeterCalculator()
        {
            double sum = 0;

            for (int i = 0; i < point.Length -1; i++)
            {
                sum += LengthSide(point[i], point[i + 1]);
            }

            sum += LengthSide(point[point.Length - 1], point[0]);
            Console.Write(sum);
        }

        public Figure(Point p1, Point p2, Point p3)
        {
            point = new Point[3];
            point[0] = p1;
            point[1] = p2;
            point[2] = p3;
            type = "Triangle";
        }

        public Figure(Point p1, Point p2, Point p3, Point p4)
        {
            point = new Point[4];
            point[0] = p1;
            point[1] = p2;
            point[2] = p3;
            point[3] = p4;
            type = "Tetragon";
        }

        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            point = new Point[5];
            point[0] = p1;
            point[1] = p2;
            point[2] = p3;
            point[3] = p4;
            point[4] = p5;
            type = "Pentagon";

        }

        class Program
        {
            static void Main(string[] args)
            {
                Figure figure = new Figure(new Point( 1, 1,"a"), new Point( 1, 4,"b"), new Point(7, 4,"c"), new Point(3,2,"e"));

                Console.Write("{0}, P = ", figure.type);

                figure.PerimeterCalculator();

                // Delay.
                Console.ReadKey();

            }
        }
    }
}
