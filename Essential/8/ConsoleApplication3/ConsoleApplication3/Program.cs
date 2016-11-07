using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    enum Post
    {
        Programmer = 300, 
        Director = 240,
        Manager = 270
    }

    class Accauntant
    {
       public bool AskForBonus(Post worker, int hours)
        {
            var a = (int)worker < hours;
            return a;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Accauntant ac = new Accauntant();
            if (ac.AskForBonus(Post.Director, 40))
            {
                Console.WriteLine("Bonus");
            }
           else Console.WriteLine("NO_Bonus");
            Console.ReadKey();
        }
    }
}
