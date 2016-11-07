using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    struct Notebook
    {
       public string model;
        string creatorBy;
        double cost;

        public Notebook(string m, string c, double co)
        {
            model = m;
            creatorBy = c;
            cost = co;
        }
       public void Show()
        {
            Console.WriteLine("Mode: {0} by {1} and cost: {2}$",model,creatorBy,cost);
        }
    } 

    class Program
    {
        static void Main(string[] args)
        {
            Notebook note = new Notebook("Lenovo", "USA", 1000);
            note.Show();
            Console.ReadKey();
        }
    }
}
