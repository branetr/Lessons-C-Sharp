using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Pupil
    {
        public virtual void Study() { Console.WriteLine("stud"); }
        public void GGG()
        {
            Console.WriteLine("ggggg");
        }
    }
    class NormalPupil: Pupil
    {
        public void NNN()
        {
            Console.WriteLine("gттттттттттттg");
        }
        public override void Study()
        {
            Console.WriteLine("Norm Student");
            
        }
    }

    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Bad Student");
        }
    }
}
