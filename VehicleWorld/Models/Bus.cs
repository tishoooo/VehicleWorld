using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleWorld
{
    public class Bus : Vehicle
    {
        public int Capacity { get; set; }
        public Bus(int capacity, string name, int maxSpeed, int milage) : base(name, maxSpeed, milage)
        {
            Capacity = capacity;
        }
        public override void GetVehicleInformation()
        {
            Console.WriteLine($"Name:{this.Name}, MaxSpeed:{this.MaxSpeed}, Milage:{this.Milage}, Capacity: {this.Capacity}");
        }
    }
}
