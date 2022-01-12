using System;
using Transport.Models;

namespace Transport
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(50, 20, 1);

            car.Drive(5);
            car.Drive(15);
        }
    }
}
