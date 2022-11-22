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
        
        public Car(string name, int maxSpeed, int milage, Engine engine) : base(name, maxSpeed, milage)
        {
            Engine = engine;
        }

        public Engine Engine { get; set; }

        public override void GetVehicleInformation()
        {
            Console.WriteLine($"Name: {this.Name}, MaxSpeed: {this.MaxSpeed}, Mileage: {this.Mileage}," +
                $" Origin: {this.Origin}, Engine type:{this.Engine.EngineType}, " +
                $"Horse Power:{this.Engine.Horsepower}");
        }
    }
}
