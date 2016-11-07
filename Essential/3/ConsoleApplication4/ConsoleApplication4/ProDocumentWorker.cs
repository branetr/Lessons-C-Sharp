using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class ProDocumentWorker : DocumentWorker
    {
        public override void OpenDocument()
        {
            base.OpenDocument();
        }
        public override void EditDocument()
        {
            Console.WriteLine("Edit doc in pro ver");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Save doc in pro ver"); 
        }
    }
}
