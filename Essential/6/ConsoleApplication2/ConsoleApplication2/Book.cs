using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    static class Book
    { 
       static public void Soort(this string lol)
        {
            lol = "Roma";
            Console.WriteLine(lol);
        }
       public class Noted
        {
            
           public string b;
            public void Save(string a)
            {
               b= a+=" Roman";
            }

        }
    }
}
