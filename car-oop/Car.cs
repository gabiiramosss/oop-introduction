using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace car_oop
{
    public class Car
    {
        //Propriedades
        public string Brand;
        public string Color;
        public Car()
        {
            
        }
        public Car(string brand, string color)
        {
            Brand = brand;
            Color = color;
        }
    }
}