using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Plane plane = new Plane();
            Vehicle shop = new Ship();
            plane.Cost();
            plane.Situatit();
            plane.Speed();
            plane.HeigtAnDpaagirs();

            Console.ReadKey();
        }
    }
}
