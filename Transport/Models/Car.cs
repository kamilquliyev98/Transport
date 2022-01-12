using System;
using System.Collections.Generic;
using System.Text;

namespace Transport.Models
{
    class Car : Vehicle
    {
        public double FuelCapacity {
            get
            {
                return _fuelCapacity;
            }
            set
            {
                if (value < _currentFuel)
                {
                    return;
                }

                _fuelCapacity = value;
            }
        }
        private double _fuelCapacity;
        public double CurrentFuel
        {
            get
            {
                return _currentFuel;
            }
            set
            {
                if (_fuelCapacity < value)
                {
                    return;
                }

                _currentFuel = value;
            }
        }
        private double _currentFuel;
        public double FuelFor1km { get; set; }

        public Car(double fuelCapacity, double currentFuel, double fuelFor1km)
        {
            if (fuelCapacity < currentFuel)
            {
                Console.WriteLine("Cari yanacaq hecmi umumi yanacaq hecminden boyuk ola bilmez...");
                return;
            }

            FuelCapacity = fuelCapacity;
            CurrentFuel = currentFuel;
            FuelFor1km = fuelFor1km;
        }

        public override void Drive(double km)
        {
            if (CurrentFuel / FuelFor1km >= km)
            {
                CurrentFuel -= FuelFor1km * km;
                Millage += km;
                Console.WriteLine($"\n{km} km yol surule biler.");
                Console.WriteLine("Teyinat noqtesine catdiqdan sonra:");
                Console.WriteLine($"Qaliq benzin: {CurrentFuel}");
                Console.WriteLine($"Umumi gedilen yol: {Millage} km\n");
            }
            else
            {
                Console.WriteLine($"\n{km} km yol getmek ucun kifayet qeder benzin yoxdur.\n");
            }
        }
    }
}
