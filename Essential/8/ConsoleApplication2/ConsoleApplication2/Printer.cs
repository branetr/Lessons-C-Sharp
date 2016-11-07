using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
   static class Printer
    {
        public static void Print(string stroka, int color)
        {
            switch (color)
            {
                case (int)ColorS.Blue:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case (int)ColorS.Green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case (int)ColorS.Red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                default:
                    Console.WriteLine("Введенная Вами строка будет выведена на экран цветом по умолчанию!");
                    break;
            }
            Console.WriteLine(stroka);
        }

        enum ColorS
        {
           Red = 3 , Green =2, Blue = 1 
        }

    }
}
