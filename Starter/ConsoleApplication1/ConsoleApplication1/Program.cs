using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            Calculate(10, 5, 9);  
        }

        static void Calculate(int a,int b, double c)
        {
            Console.WriteLine("a/5 = {0}, b/5 = {1}, c/5 = {2}", a/5, b/5, c/5 );
            Console.ReadKey();
        }
    }

}
