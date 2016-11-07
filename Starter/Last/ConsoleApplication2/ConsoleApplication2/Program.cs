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
            Console.WriteLine("Enter N of mass: ");
            var n = Convert.ToInt32(Console.ReadLine());

            create_array(n);      
            Console.ReadKey();
        }

        static void create_array(int a)
        {
            int[] array = new int[a];
            Console.WriteLine("Enter array");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("-------------Reverse array:");
            MyReverse(array);
            Console.WriteLine("-------------");
             
            Console.WriteLine("Enter index for new array and him dimension: ");
            var index = Convert.ToInt32(Console.ReadLine());
            var count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-------------");
            SubArray(array, index, count);     
        }

        static int[] MyReverse(int[] array)
        {
            array = array.Reverse().ToArray();
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            return array;
        }

        static int[] SubArray(int[] array, int index, int count)
        {
             var array1 = new int[count];
            var k = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                if (index < array.Length)
                {
                    array1[k] = array[index];
                }
                else
                    array1[k] = 9;

                Console.WriteLine(array1[i]);
                index++;
                k++;
            }

            return array1;
        }
    }

}
