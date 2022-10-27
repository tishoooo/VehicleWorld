using System;

namespace VehicleWorld
{


    public class Vehicle
    {
        public string Name { get; set; }
        public int MaxSpeed { get; set; }
        public int Milage { get; set; }
        public Vehicle() { }
        public Vehicle(string name, int maxSpeed, int milage)
        {
            this.Name = name;
            this.MaxSpeed = maxSpeed;
            this.Milage = milage;
        }

        public virtual void GetVehicleInformation()
        {
            Console.WriteLine($"Name:{this.Name}, MaxSpeed:{this.MaxSpeed}, Milage:{this.Milage}");
        }
    }
}
