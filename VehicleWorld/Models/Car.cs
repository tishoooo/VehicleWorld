using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleWorld
{
    /// <summary>
    /// Car.
    /// </summary>
    public class Car : Vehicle
    {
        public Car(string name, int maxSpeed, int milage)
            : base(name, maxSpeed, milage)
        {
        }
    }
}
