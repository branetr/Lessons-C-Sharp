using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Printer
    {
        virtual public void Print(string value)
        {
            Console.WriteLine(value);
        } 
    }
    class Program
    {
        static void Main(string[] args)
        {
            Printer prin = new PrinterOne();
            prin.Print("Lol");

            Console.ReadKey();

        }
    }
}
