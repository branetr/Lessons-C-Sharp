using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void OpenDocument()
        {
            base.OpenDocument();
        }
       
        public override void EditDocument()
        {
            Console.WriteLine("Edit doc in Exp");
        }
    }
}
