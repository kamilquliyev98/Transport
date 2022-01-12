using System;
using System.Collections.Generic;
using System.Text;

namespace Transport.Models
{
    abstract class Vehicle
    {
        public string Colour { get; set; }
        public string Brand { get; set; }
        public double Millage { get; set; }

        public virtual string ShowInfo()
        {
            return $"Brand: {Brand}\nColour: {Colour}\nMillage: {Millage}";
        }

        public abstract void Drive(double km);
    }
}
