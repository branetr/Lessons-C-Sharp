using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class PrinterOne : Printer
    {
        public override void Print(string value)
        {
            Console.WriteLine(value);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(value);
        }
    }
}
