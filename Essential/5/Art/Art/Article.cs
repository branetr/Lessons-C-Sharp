using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Art
{
    class Article
    { 
        private string name, nameofmaraz;
        private double cost;

        public string Name
        {
            get
            {
                if (name==null)
                {
                     Console.WriteLine("Немає такого товару");
                    return null;
                }
                return name;
            }
            set
            {
                if (value==null)
                {
                    Console.WriteLine("Невірно введено інформацію про назву товару");
                }
                name = value;
            }
        }

        public string Nameofmagaz
        {
            get
            {
                if (nameofmaraz == null)
                {
                    Console.WriteLine("Немає такого магазину");
                    return null;
                }
                return nameofmaraz;
            }
            set
            {
                if (value == null)
                {
                    Console.WriteLine("Невірно введено інформацію про назву магазину");
                }
                nameofmaraz = value;
            }
        }

        public double Cost
        {
            get
            {
                if (cost <=0.2)
                {
                    Console.WriteLine("Невказано ціни");
                    return cost;
                }
                return cost;
            }
            set
            {
                if (value <= 0.2 )
                {
                    Console.WriteLine("Невірно введено ціна");
                }
                cost = value;
            }
        }
        
        public Article(string name, string nameofmagaz, double cost)
        {
            Name = name;
            Nameofmagaz = nameofmagaz;
            Cost = cost;
        }
        public Article(string name)
        {
            Name = name;
        }
        public string Info()
        {
            return string.Format("{0} из {1} стоимость : {2} грн.", Name, Nameofmagaz, Cost);
        }
    }
}
