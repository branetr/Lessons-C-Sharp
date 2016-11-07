using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Art
{
    class Program
    {
        static void Main(string[] args)
        {
            Store st = new Store(3);

            st.AddArticle(new Article("Book", "MackMilan", 20.50), 0);
            st.AddArticle(new Article("Apple", "Delight", 5.90), 1);
            st.AddArticle(new Article("Coca-Cola", "Fozzy", 7.25), 2);


            Console.WriteLine(st["Apple"]);
            Console.WriteLine(new string('-', 30));

            Console.WriteLine(st["Dog"]);
            Console.WriteLine(new string('-', 30));

            Console.WriteLine(st[2]);
            Console.WriteLine(new string('-', 30));

            st.Show();
            Console.WriteLine(new string('-', 30));

            st.Sort();
            st.Show();

            Console.ReadKey();
        }
    }
}
