using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class ClassRoom
    {
        Pupil[] pup = new Pupil[2];
        public ClassRoom(Pupil p1, Pupil p2)
        {
            pup[0] = p1;
            pup[1] = p2;      
        }
        public void ShowWhoAreyou()
        {
            foreach (Pupil p in pup)
            {
                p.Study();
            }
        }
    }
}
