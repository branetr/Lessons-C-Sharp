using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N of mass: ");
            var n = Convert.ToInt32(Console.ReadLine());
            int[] arrey = new int[n] ;
            Console.WriteLine("Enter arrey"); 

            for (int i = 0; i < arrey.Length; i++)
            {
                arrey[i]= Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("-------------");

            var max = arrey[0];
            var min = arrey[0];
            var suma = 0;
           

            for (int i = 0; i < arrey.Length; i++)
            {
                if (max < arrey[i])
                {
                    max = arrey[i];
                }
                if (min > arrey[i])
                {
                    min = arrey[i];
                };
                suma += arrey[i];
                if ((arrey[i] % 2) != 0)
                {
                    Console.WriteLine(arrey[i]);
                }
            }
            Console.WriteLine("-------------");
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine("Suma = {0}", suma);
            Console.WriteLine("ser. aref = {0}", suma/n);
            Console.ReadKey();
        }
    }
}
