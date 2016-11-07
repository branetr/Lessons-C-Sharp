using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    delegate int M1();
     
    class Program
    {
        static void Main(string[] args)
        {
            M1 m;
            Random random = new Random();
            double sum = 0;
           
            Console.WriteLine("enter N elements");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a =  new int[n];                                                                                                                                                                                                                                                                               

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(0,10);
                sum += a[i];
            }
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine(sum/n);
            Console.ReadKey();
        }
    }    
}
