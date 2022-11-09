namespace VehicleWorld
{
    using System;

namespace VehicleWorld
{
    /// <summary>
    /// The Vehicle class.
    /// </summary>
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

        /// <summary>
        /// Gets Name property.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets MaxSpeed property.
        /// </summary>
        public int MaxSpeed { get; private set; }

        /// <summary>
        /// Gets Mileage property.
        /// </summary>
        public int Mileage { get; private set; }

        /// <summary>
        /// Displays Vehicle information.
        /// </summary>
        public virtual void GetVehicleInformation()
        {
            Console.WriteLine($"Name: {this.Name}, MaxSpeed: {this.MaxSpeed}, Mileage: {this.Mileage}");
        }
    }
}
