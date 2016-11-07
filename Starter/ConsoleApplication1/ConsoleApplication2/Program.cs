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
            OutCredit();
        }
        static int TakeCred()
        {
            Console.WriteLine("Write your credit: ");
            int credit = int.Parse(Console.ReadLine());
            return credit;
        }

        static public void OutCredit()
        {
            int NumberVnesok = 0;
            var Vnesok = 0;
            int credit = TakeCred();
            do
            {
                NumberVnesok++;
                Console.WriteLine("Enter your {0} :", NumberVnesok);
                Vnesok += int.Parse(Console.ReadLine());
                if (Vnesok>=credit)
                {
                    Console.WriteLine("You haven`t credit ^_^ Urayyy");
                    break;
                }
            } while (NumberVnesok <7);
            if (NumberVnesok>=7 && credit>Vnesok)
            {
                Console.WriteLine("Your credetor will kill U ;)ahaha");
            }
            
            Console.ReadKey();

        }
    }
}
