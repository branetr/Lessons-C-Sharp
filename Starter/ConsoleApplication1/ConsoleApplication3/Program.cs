using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static int Factorail(int n)
        {
            if (n==0)
            {
                return 1;
            }
            return n * Factorail( n - 1);
        } 

        static void Main(string[] args)
        {
            Console.WriteLine("Ведіть число, факторіал якого будемо шукати:");
            var a = int.Parse(Console.ReadLine());
            var fac = Factorail(a);
            Console.WriteLine("Факторіал числа {0} рівний {1}",a,fac);
            Console.ReadKey();
        }
    }
}
