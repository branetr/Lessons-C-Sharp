using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Who are: Pro, Exp  or Base?");
            string switch_on = Console.ReadLine();
            DocumentWorker exp;
            switch (switch_on)
            {
                case "Pro": { exp = new ProDocumentWorker(); break; }
                case "Exp": { exp = new ExpertDocumentWorker(); break; }
                case "Base": { exp = new DocumentWorker(); break; }
                default: { exp = null; Console.WriteLine("Bad input"); ; break; }
            }
            if (exp!=null)
            {
                exp.SaveDocument();
            }       
            Console.ReadKey();
        }
    }
}
