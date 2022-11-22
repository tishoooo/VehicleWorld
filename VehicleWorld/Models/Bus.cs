using System;

namespace VehicleWorld
{
    /// <summary>
    /// Bus.
    /// </summary>
    public class Bus : Vehicle
    {
        public Bus(int capacity, string name, int maxSpeed, int milage, Engine engine) 
            : base(name, maxSpeed, milage)
        {
            Capacity = capacity;
            Engine = engine;
        }

        public int Capacity { get; set; }

        public Engine Engine { get; set; }

        public override void GetVehicleInformation()
        {
            Console.WriteLine($"Name: {this.Name}, MaxSpeed: {this.MaxSpeed}, Mileage: {this.Mileage}, Capacity: {this.Capacity}, Origin: {this.Origin}, Engine type:{this.Engine.EngineType}, Horse Power:{this.Engine.Horsepower}");
        }
    }
}
