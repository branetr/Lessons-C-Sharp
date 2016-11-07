using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexes_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rou and cos of array");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            MyMatrix mat = new MyMatrix(a, b);
            mat.Show();
            Console.WriteLine("Enter rang of array ");
            mat.ChangeArray(Convert.ToInt32(Console.ReadLine()));
            mat.Show();
            mat[2, 2] = 100;
            Console.WriteLine(mat[2, 2]);
            Console.ReadKey();
        }
    }
}
