using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstAndInter
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractHandler txt = new TXTHandler();
            XMLHandler xml = new XMLHandler();
            txt.Create();
           // txt.Open();
            xml.Create();
            Console.ReadKey();

        }
    }
}
