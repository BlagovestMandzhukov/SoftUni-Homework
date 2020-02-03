using System;
using System.Collections.Generic;
using System.Text;

namespace _02.NeedForSpeed.Cars
{
    public class Car : Vehicle
    {
        private const double DefaultFuelConsumption = 3;

        public Car(int horsePower, double fuel)
            : base(horsePower, fuel)
        {
        }

        public override double FuelConsumption => DefaultFuelConsumption;
    }
}
