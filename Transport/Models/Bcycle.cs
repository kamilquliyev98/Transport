using System;
using System.Collections.Generic;
using System.Text;

namespace Transport.Models
{
    class Bcycle : Vehicle
    {
        public override void Drive(double km)
        {
            Millage += km;
        }
    }
}
