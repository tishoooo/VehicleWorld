using System;

namespace VehicleWorld
{
    /// <summary>
    /// The Vehicle class.
    /// </summary>
    public class Vehicle
    {
        public Vehicle(string name, int maxSpeed, int mileage)
        {
            this.Name = name;
            this.MaxSpeed = maxSpeed;
            this.Mileage = mileage;
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

        public string Origin { get; private set; } = "Made in Bulgaria";

        /// <summary>
        /// Displays Vehicle information.
        /// </summary>
        public virtual void GetVehicleInformation()
        {
            Console.WriteLine($"Name: {this.Name}, MaxSpeed: {this.MaxSpeed}, Mileage: {this.Mileage}, Origin: {this.Origin}");
        }

          /// <summary>
        /// Displays distance information.
        /// </summary>
        /// <param name="distance">Information for distance in mileage.</param>
        public void Drive(int distance)
        {
            this.Mileage += distance;
        }
    }
}
