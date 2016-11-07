using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexes_5
{
    class MyMatrix
    {
        Random rand = new Random();

        int[,] matrix;
        int rou, cos;
        public MyMatrix(int i, int j)
        {
            
            rou = i;cos = j;
             matrix = new int[rou,cos];

            for (int i1 = 0; i1 < rou; i1++)
            {
                for (int y1 = 0; y1 < cos; y1++)
                {
                    matrix[i1, y1]=rand.Next(0,10);
                }
            }
        }

        public void ChangeArray(int rang)
        {
            rou = rang; cos = rang;
           matrix = new int[rang, rang];
            for (int i1 = 0; i1 < rang; i1++)
            {
                for (int y1 = 0; y1 < rang; y1++)
                {
                    matrix[i1, y1] = rand.Next(0, 10);
                }
            }

        }

        public void Show()
        {
            for (int i = 0; i < rou; i++)
            {
                for (int y = 0; y < cos; y++)
                {
                    Console.Write(matrix[i,y]);
                }
                Console.WriteLine();
            }
        }

        public int this[int index1, int index2]
        {
            get
            {
                if (index1 >= 0 && index1 <= rou && index2 >= 0 && index2 <= cos)
                    return matrix[index1,index2];
                Console.WriteLine("Попытка обращения за пределы массива.");
                return 0;
            }

            set
            {
                if (index1 >= 0 && index1 <= rou && index2 >= 0 && index2 <= cos)
                    matrix[index1,index2] = value;
                else
                    Console.WriteLine("Попытка записи за пределами массива.");
            }
        }
    }
}
