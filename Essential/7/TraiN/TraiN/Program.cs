using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraiN
{
    struct Train
    {
       public string goTo;
       public int numberOfTrain;
       public DateTime timetogo;
        
    }

    class Program
    {
        Train[] train = new Train[3];
        void Input()
        {
            for (int i = 0; i < train.Length; i++)
            {
                Console.WriteLine("Ведіть місце призначення, номер поїзду та час відправлення");
                train[i].goTo = Console.ReadLine();
                train[i].numberOfTrain = Convert.ToInt32(Console.ReadLine());
                train[i].timetogo = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine();
            }
            Array.Sort(train, new Comparison<Train>((a, b) => a.numberOfTrain.CompareTo(b.numberOfTrain)));
        }
        void Show()
        {
            for (int i = 0; i < train.Length; i++)
            {
                Console.WriteLine("Номер поезда: {0} Пункт назначения: {1} Дата и время отправления: {2} ", train[i].goTo, train[i].numberOfTrain, train[i].timetogo);
                Console.WriteLine();
            }
        }
        void ShowTrain(int n)
        {
            for (int i = 0; i < train.Length; i++)
            {
                if (train[i].numberOfTrain==n)
                {
                    Console.WriteLine("Номер поезда: {0} Пункт назначения: {1} Дата и время отправления: {2} ", train[i].goTo, train[i].numberOfTrain, train[i].timetogo);
                    Console.WriteLine();
                }
                else Console.WriteLine("Такого  поїзда не існує");
            }
        }


        static void Main()
        {
            Program pro = new Program();
            pro.Input();
            pro.Show();
            pro.ShowTrain(10);
            Console.ReadKey();
        }
    }
}
