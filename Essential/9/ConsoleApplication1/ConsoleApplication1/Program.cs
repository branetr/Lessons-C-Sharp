using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{ 
    delegate double Dell(int a, int b, int c);
      
    class Program
    {
        static void Main(string[] args)
        {       
            Dell D = (a, b, c) => (double)(a + b + c )/3;
            Console.WriteLine(D(2, 3, 2));
            Console.ReadKey();
        }
    }
}
