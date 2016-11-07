using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invouceee
{
    class Invoice
    {
        readonly int account;
       readonly string customer, provider;
         string article; int quantity;

        public string Article
        {
            get
            {
                return article;
            }

            set
            {
                article = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                if (value > 0)
                      quantity = value;
            }
        }

        public int how_much()
        {
            int price=0;

            switch (Article)
            {
                case "Nout":price=300;break;
                case "CD": price = 15; break;
                default:
                    Console.WriteLine("Немає такого товару");
                    break;
            }
            price *= quantity;
            return price;
        }

        public Invoice(int ac, string cus, string prov)
        {
            this.account = ac;
            this.customer = cus;
            this.provider = prov;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Invoice inv = new Invoice(244, "Roma", "Elmart");
            Console.WriteLine("Enter tovar: Nout or CD");
            inv.Article = Console.ReadLine();
            Console.WriteLine("Enter how many");
            inv.Quantity = Convert.ToInt32(Console.ReadLine());
            Console.Write("U buy {0} - {1}. This cost for U: ",inv.Quantity,inv.Article);
            Console.WriteLine(inv.how_much());
            Console.ReadKey();
        }
    }
}
