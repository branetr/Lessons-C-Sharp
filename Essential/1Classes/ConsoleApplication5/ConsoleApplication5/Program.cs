using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class User
    {
        string login;
        string name;
        int age;
       public readonly DateTime date;

        public string Login
        {
            get
            { 
                return login;
            }

            set
            {
                if (value=="C")
                {
                    login = "Cap777";
                }   
                login = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public User(string a, string b, int c)
        {
            this.login = a;
            this.name = b;
            this.age = c;
            date = DateTime.Now;
        }

        class Program
        {
            static void Main(string[] args)
            {
                User user = new User("C", "Roma", 20);
                Console.WriteLine(user.Login);
                Console.ReadKey();   
            }
        }
    }
}
