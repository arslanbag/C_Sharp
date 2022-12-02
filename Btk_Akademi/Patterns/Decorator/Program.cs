﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonelCar personelCar = new PersonelCar { Make="BWM" ,Model = "3.20", HirePrice = 2500 };
            SpecialOffer specialOffer = new SpecialOffer(personelCar);
            specialOffer.DiscountPercentage = 10;

            Console.WriteLine("Concrete : " + personelCar.HirePrice);
            Console.WriteLine("Special Offer : " + specialOffer.HirePrice);

            Console.ReadLine();
        }
    }
    abstract class CarBase 
    {
        public abstract string Make { get; set; }
        public abstract string Model { get; set; }
        public abstract decimal HirePrice { get; set; }
    }
    class PersonelCar : CarBase
    {
        public override string Make { get ; set; }
        public override string Model { get; set; }
        public override decimal HirePrice { get ; set; }
    }
    class CommercialCar : CarBase
    {
        public override string Make { get; set; }
        public override string Model { get; set; }
        public override decimal HirePrice { get; set; }
    }

    abstract class CarDecoratorBase : CarBase
    {
      private CarBase _carBase;
        protected CarDecoratorBase(CarBase carBase) 
        {
            _carBase = carBase;
        }
    }

    class SpecialOffer : CarDecoratorBase
    {
        private readonly CarBase _carBase;
        public int DiscountPercentage;

        public SpecialOffer(CarBase carBase) : base(carBase)
        {
            _carBase = carBase;
        }
        public override string Make { get ; set ; }
        public override string Model { get; set; }
        public override decimal HirePrice 
        { 
            get 
            {
                return _carBase.HirePrice - _carBase.HirePrice * DiscountPercentage / 100 ;
            }
            set 
            {
                
            } 
        }
    }


}
