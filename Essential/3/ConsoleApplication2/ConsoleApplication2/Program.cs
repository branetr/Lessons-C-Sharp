using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil p1 = new NormalPupil();
            Pupil p2 = new BadPupil();

            ClassRoom grupa = new ClassRoom(p1, p2);
            grupa.ShowWhoAreyou();

            NormalPupil bad = (NormalPupil) p1;
            p1.GGG();
            Pupil bad = new Pupil();
            bad.GGG();
            
            Console.ReadKey();
        }
    }
}
