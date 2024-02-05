using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activitat1_M5UF3
{
    public class Motorbike : Vehicle
    {

        public double CubicCentimeters { get; set; }
        public bool SideCar { get; set; }

        public Motorbike(string brand, string model, string licensePlate, int years, int kms, int wheels, double cubicCentimeters, bool sideCar) : base(brand, model, licensePlate, years, kms, wheels)
        {
            CubicCentimeters = cubicCentimeters;
            SideCar = sideCar;
        }

        public bool isSideCar()
        {
            return SideCar;
        }

    }
}
