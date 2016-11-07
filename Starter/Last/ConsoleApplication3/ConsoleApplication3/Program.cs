using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {

        static  void Main(string[] args)
        {
            Console.WriteLine("Enter N of mass: ");
            var n = Convert.ToInt32(Console.ReadLine()); 

            int[] array = new int[n];
            Console.WriteLine("Enter array");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter VALUE: ");
            var value = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("----------");
            outPut(arrayPlusOne(array, value));             
            Console.ReadKey();
        }

        public static int[] arrayPlusOne(int[] array, int value)
        {
            int[] arrayP_O = new int[array.Length+1];
           
            for (int i = 0; i < array.Length; i++)
            {
                arrayP_O[i+1] = array[i];                      
            }
            arrayP_O[0] = value;
            return arrayP_O;
        }

        static void outPut(int[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }

}
