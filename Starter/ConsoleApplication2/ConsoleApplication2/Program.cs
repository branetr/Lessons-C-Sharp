using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter A and B");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            for (int i = a+1; i < b; i++)
            {
                if (i % 2==1)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }

       
    }
}
