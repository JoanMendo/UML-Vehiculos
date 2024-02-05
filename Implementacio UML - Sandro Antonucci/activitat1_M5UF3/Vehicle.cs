using System;
using System.Runtime.CompilerServices;

namespace activitat1_M5UF3
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string LicensePlate { get; set; }
        public int Years { get; set; }
        public int Kms { get; set; }
        public int Wheels {  get; set; }

        public Vehicle(string brand, string model, string licensePlate, int years, int kms, int wheels)
        {
            Brand = brand;
            Model = model;
            LicensePlate = licensePlate;
            Years = years;
            Kms = kms;
            Wheels = wheels;
        }
        
        public virtual bool IsOlder()
        {
            return Years > 15;
        }
    }
}
