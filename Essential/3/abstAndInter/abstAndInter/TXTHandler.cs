using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstAndInter
{
    class TXTHandler: AbstractHandler
    {
        protected override void Open()
        {
            Console.WriteLine("Open TXT") ;
        }
        public override void Create()
        {
            Console.WriteLine("Create TXT");
        }
    }
}
