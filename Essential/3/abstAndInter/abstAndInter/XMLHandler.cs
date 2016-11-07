using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstAndInter
{
    class XMLHandler : AbstractHandler
    {
        protected override void Open()
        {
            Console.WriteLine("Open XML");
        }
        public override void Create()
        {
            Console.WriteLine("Create XML");
        }
    }
}
