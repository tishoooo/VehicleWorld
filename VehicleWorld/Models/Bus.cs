using System;

namespace VehicleWorld
{
    /// <summary>
    /// Bus.
    /// </summary>
    public class Bus : Vehicle
    {
        public int Capacity { get; set; }
        public Bus(int capacity, string name, int maxSpeed, int milage) : base(name, maxSpeed, milage)
        {
            Capacity = capacity;
        }
        public override void GetVehicleInformation()
        {
            Console.WriteLine($"Name: {this.Name}, MaxSpeed: {this.MaxSpeed}, Mileage: {this.Mileage}, Capacity: {this.Capacity}, Origin: {this.Origin}");
        }
    }
}
