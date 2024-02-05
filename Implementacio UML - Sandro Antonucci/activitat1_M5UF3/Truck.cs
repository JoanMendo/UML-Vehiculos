using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activitat1_M5UF3
{
    public class Truck : Vehicle
    {

        public string Type { get; set; }
        public double Tones { get; set; }

        public Truck(string brand, string model, string licensePlate, int years, int kms, int wheels, string type, double tones) : base(brand, model, licensePlate, years, kms, wheels)
        {
            Type = type;
            Tones = tones;
        }

        public bool isHeavy()
        {
            return Tones > 15;
        }

    }
}
