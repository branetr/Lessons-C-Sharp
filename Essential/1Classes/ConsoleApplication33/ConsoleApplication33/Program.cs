using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Title title = new Title();
            Author author = new Author();
            Content content = new Content();

            Console.WriteLine("Enter Title: ");
            title.Tit = Console.ReadLine();

            Console.WriteLine("Enter Author: ");
            author.Aut = Console.ReadLine();

            Console.WriteLine("Enter Content: ");
            content.Cont = Console.ReadLine();

            title.show();
            author.show();
            content.show();


            Console.ReadKey();
        }
    }

    class Book
    {
        public void Show()
        {
            
        }
    }
    class Title
    {
        private string tit;
        public string Tit { set { tit = value; } get { return tit; } }
        public void show()
        {
            Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("Title {0} ", tit);
        }
    }

    class Author
    {
        private string aut;
        public string Aut {  set { aut = value; } get { return aut; } }
        public void show()
        {
            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Author {0} ", aut);
        }
    }

    class Content
    {
        private string cont;
        public string Cont { set { cont = value; } get { return cont; } }
        public void show()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Content: {0} ", cont);
        }

    }
}
