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
            Book book = new Book();
            Title title = new Title();
            Author author = new Author();
            Content content = new Content();

            Console.WriteLine("Enter Title: ");
            new Title().Tit = Console.ReadLine();

            Console.WriteLine("Enter Author: ");
            new Author().Aut = Console.ReadLine();

            Console.WriteLine("Enter Title: ");
            new Content().Cont = Console.ReadLine();

          
            book.Show();
            Console.ReadKey();
        }
    }

    class Book
    {
        public void Show()
        {


            title.show();
            author.show();
            content.show();
        }
    }
    class Title
    {
        private string tit;
        public string Tit { get { return tit; } set { tit = value; } }
        public void show()
        {
            Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("Title {0} ", tit);
        }
    }

    class Author
    {
        private string aut;
        public string Aut { get { return aut; } set { aut = value; } }
        public void show()
        {
            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Author {0} ", aut);
        }
    }

    class Content
    {
        private string cont;
        public string Cont { get { return cont; } set { cont = value; } }
        public void show()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Content: {0}, ", cont);
        }

    }
}