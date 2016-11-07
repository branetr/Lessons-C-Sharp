using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converterrrr
{
    class Converter
    {
       public double ConvertFromTo(double a)
        {
             var convert = Convert.ToDouble(Console.ReadLine());
            return a*convert;
        }

       public double usd, eur, rub;
        double uhr;
      

        public Converter(double usd, double eur, double rub)
        {
            this.usd = ConvertFromTo(usd);
            this.eur = ConvertFromTo(eur);
            this.rub = ConvertFromTo(rub);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter info  whow many money do u have: USD, EUR and RUB");
            var usd=Convert.ToDouble(Console.ReadLine());
            var eur = Convert.ToDouble(Console.ReadLine());
            var rub = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter convert USD, EUR and RUB to 1 UHR");
            Converter converter = new Converter(usd, eur, rub);
            Console.WriteLine("__________");
            Console.WriteLine(converter.usd);
            Console.WriteLine(converter.eur);
            Console.WriteLine(converter.rub);
            Console.ReadKey();   
        }
    }
}
