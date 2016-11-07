using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
     class Vehicle
    {
        protected string situatit;
       public virtual void Situatit()
        {
          string  situatit="Невказано";
        }

        protected int cost;
        public virtual void Cost()
        {
         int cost;
        }

        protected double speed;
        public virtual void Speed()
        {
        double speed;
        }

    }

    class Plane : Vehicle
    {
        public override void Situatit()
        {
            Console.WriteLine(situatit = "America"); 
        }
        public override void Cost()
        {
            Console.WriteLine(cost = 1000); 
        }
        public override void Speed()
        {
            Console.WriteLine(speed = 350); 
        }

        int height, pasagirs;
       public void HeigtAnDpaagirs()
        {
            Console.WriteLine(height = 10000);
            Console.WriteLine(pasagirs = 300);
        }      
        
    }

    class Ship : Vehicle
    {
        public override void Situatit()
        {
            Console.WriteLine(situatit = "Azia");
        }
        public override void Cost()
        {
            Console.WriteLine(cost = 800);
        }
        public override void Speed()
        {
            Console.WriteLine(speed = 170);
        }

        int  pasagirs;
        string portpropusku;
        void PortpropuskuAnDpaagirs()
        {
            Console.WriteLine(portpropusku = "UK");
            Console.WriteLine(pasagirs = 800);
        }


    }
}
