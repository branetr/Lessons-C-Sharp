using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class DocumentWorker
    {
       public virtual void OpenDocument()
        {
            Console.WriteLine("Open doc");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Edit doc");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Save doc");
        }
    }
}
