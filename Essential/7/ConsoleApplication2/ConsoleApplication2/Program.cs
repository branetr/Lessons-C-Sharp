using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "Изменено";
        }

        static void StruktTaker(MyStruct myStruct)
        {
            Console.WriteLine(myStruct.change);
            myStruct.change = "Изменено";
        }

        static void Main(string[] args)
        {
            MyClass myC = new MyClass();
            MyStruct myS;

            myC.change = "Рома";
            myS.change = "Рома";

            ClassTaker(myC);
            StruktTaker(myS);
            Console.WriteLine("");
            Console.WriteLine(myC.change);
                       
            Console.WriteLine(myS.change);
            Console.ReadKey();

        }
    }
}
