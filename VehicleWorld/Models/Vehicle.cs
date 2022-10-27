using System;

namespace VehicleWorld
{
    /// <summary>
    /// The Vehicle class.
    /// </summary>
    public class Vehicle
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Vehicle"/> class..
        /// </summary>
        /// <param name="name">Vehicle's name.</param>
        /// <param name="maxSpeed">Vehicle's max speed.</param>
        /// <param name="mileage">Vehicle's mileage.</param>
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

        /// <summary>
        /// Displays Vehicle information.
        /// </summary>
        public virtual void GetVehicleInformation()
        {
            Console.WriteLine($"Name: {this.Name}, MaxSpeed: {this.MaxSpeed}, Mileage: {this.Mileage}");
        }
    }
}
