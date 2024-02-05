using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activitat1_M5UF3
{
    public class Car : Vehicle
    {

        public int Doors { get; set; }
        public string Color { get; set; }

        public Car(string brand, string model, string licensePlate, int years, int kms, int wheels, int doors, string color) : base(brand, model, licensePlate, years, kms, wheels)
        {
            Doors = doors;
            Color = color;
        }

        public bool isBig()
        {
            return Years > 15;
        }

    }
}
