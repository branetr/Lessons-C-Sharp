using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Address
    {
        string index;
        string country;
        string street;
        public string Index
        {
            set
            {
                if (value=="22")
                {
                    index = "dva/dva";
                }
                else index = value; }
            get { return index; }
        }

        public string Country
        {
            set { country = value; }
            get
            {
                if (country== "Ukraine")
                {
                    return "You loser in your country";
                }else
                    return country; }
        }

        public string Street
        {
            set { street = value; }
            get
            {
                if (street== "Zebrova")
                {
                    return street.ToLower();
                }else
                return street; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            address.Index = "22";
            address.Country = "Ukraine";
            address.Street = "Zebrova";

            Console.WriteLine(address.Index);
            Console.WriteLine(address.Street);
            Console.WriteLine(address.Country);
            Console.ReadKey();
        }
    }
}
