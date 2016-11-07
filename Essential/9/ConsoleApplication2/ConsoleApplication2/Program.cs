using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    delegate double D(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            D multi = (a, b) => a * b;
            D div = (a, b) => (double) a / b;
            D add = (a, b) => a + b;
            D sub = (a, b) => a - b;

            Console.WriteLine("Enter A and B:");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("multi - 1, div - 2, add - 3 or sub - 4 ?");
            string switch_on = Console.ReadLine();
            switch (switch_on)
            {
                case "1": Console.WriteLine(multi(a1, b1)); break;
                case "2":
                    if (b1!=0)
                    {
                        Console.WriteLine((double)div(a1, b1));
                    }
                    else
                    {
                        Console.WriteLine("B cant be 0");
                    }             
                    break;
                case "3": Console.WriteLine(add(a1, b1));break;
                case "4": Console.WriteLine(sub(a1, b1));break;

                default: Console.WriteLine("Bad value"); break;
            }
            Console.ReadKey();
        }
        
    }
}
