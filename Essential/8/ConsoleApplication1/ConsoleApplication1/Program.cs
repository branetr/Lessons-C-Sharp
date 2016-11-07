using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDay myday = new MyDay();
            Console.WriteLine("enter day of u");
            DateTime d = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("{0} days for yours birthday", myday.MyNextBirthdey(d));
            Console.ReadKey();
        }
    }
}
