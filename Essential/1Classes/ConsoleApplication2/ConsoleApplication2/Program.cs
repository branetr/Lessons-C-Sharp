using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Rectangle
    {
        private double side1, side2;

        public Rectangle()
        {
            side1 = 0; side2 = 0;
        }
        public Rectangle(double side1, double side2)
        {
           this.side1 = side1;
            this.side2 = side2;
        }

        double AreaCalculator()
        {
            return side1 * side2;
        }
        double Area
        {
            get
            {
                if (side1 <= 0 | side2 <= 0)
                {
                    return 1;
                }
                else return this.AreaCalculator();
            }
        }

        double PerimeterCalculator()
        {
            return 2 * (side1 + side2);
        }

   
        double Perimeter
        {
            get
            {
                if (side1 <= 0 | side2 <= 0)
                {
                    return 1;
                }
                else return this.PerimeterCalculator();
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter side 1 and side 2 :");
                double side1 = Convert.ToDouble(Console.ReadLine());
                double side2 = Convert.ToDouble(Console.ReadLine());

                Rectangle rectangle = new Rectangle(side1, side2);
                if (rectangle.Perimeter!=1 | rectangle.Area!=1)
                {
                    Console.WriteLine("Perimeter = {0}, Area= {1}", rectangle.Perimeter, rectangle.Area);
                }
                else Console.WriteLine("Bad parametres =(");             
                Console.ReadKey();
            }
        }
    }
}
