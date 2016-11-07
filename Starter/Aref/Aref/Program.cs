using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aref
{
    class Program
    {
        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Sub(double a, double b)
        {
            return a - b;
        }

        static double Sum(double a, double b)
        {
            return a * b;
        }

        static double Div(double a, double b)
        {
            if (b==0)
            {
                Console.WriteLine("Не можна д1лити на 0 ");
                return 1;
            }
            return a / b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Вед1ть число A та B");
            var a = Convert.ToDouble(Console.ReadLine());
            var b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Вед1ть арефметичний операц1ю ( +, -, * або / )");
            string switch_on = Console.ReadLine();
            switch (switch_on)
            {
                case "+":
                    Console.WriteLine("Cума чисел = {0}", Add(a, b));
                    break;
                case "-":
                    Console.WriteLine("Р1зниця чисел = {0}", Sub(a, b));
                    break;
                case "*":
                    Console.WriteLine("Добуток чисел = {0}", Sum(a, b));
                    break;
                case "/":
                    Console.WriteLine("Ділення чисел = {0}", Div(a, b));
                    break;
                default:
                    Console.WriteLine("Ви вели неправильний арефметичний знак =( ");
                    break;
            }

            Console.ReadKey();
        }
    }
}
