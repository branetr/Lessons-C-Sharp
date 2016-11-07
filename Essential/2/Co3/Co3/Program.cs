using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Co3
{
    class Employee
    {
        readonly string name, secondname;
        string posada;
        int exp;

        public Employee(string name, string secondname)
        {
            this.name = name; this.secondname = secondname;
        }
       public double Zarplata()
        {
            double zarplata;
            switch (Posada)
            {
                case "maneger": zarplata = 127; break;
                case "worker": zarplata = 75;break;
                case "developer": zarplata = 150; break;
                default: zarplata = 50; break;
            }
            switch (exp)
            {
                case 1: zarplata *= 1.2; break;
                case 2: zarplata *= 1.8; break;
                case 3: zarplata *= 2.1; break;
               }
            return zarplata;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public string Secondname
        {
            get
            {
                return secondname;
            }
        }

        public int Exp
        {
            get
            {
                return exp;
            }

            set
            {
                if (value >= 0)
                    exp = value;
            }
        }

        public string Posada
        {
            get
            {
                if (posada ==null)
                {
                    return "NotWorking";
                }
                return posada;
            }

            set
            { if(value!=null)
                posada = value;
            }
        }
        public void money()
        {
            Console.WriteLine(Zarplata()+" and lost "+Zarplata()*0.08);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter U name ");
            var n1 = Console.ReadLine();
            Console.WriteLine("Enter U secondname");
            var n2 = Console.ReadLine();
            Employee employer = new Employee(n1, n2);

            Console.WriteLine("Chose U work : maneger, worker, developer ");
            employer.Posada = Console.ReadLine();
            Console.WriteLine("Chose U exp :Put 1 if u work to 1year, Put 2 - 1 from 2 yesrs and put 3 - more then 2 years  ");
            employer.Exp = Convert.ToInt32(Console.ReadLine());
            Console.Write("{0} {1}, you are {2} and get ", employer.Name,employer.Secondname,employer.Posada);
            employer.money();
            Console.ReadKey();
        }
    }
}
