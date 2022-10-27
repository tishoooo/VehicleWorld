using System;

namespace VehicleWorld
{
    /// <summary>
    /// Bus.
    /// </summary>
    public class Bus : Vehicle
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Bus"/> class..
        /// </summary>
        /// <param name="capacity">Bus capacity.</param>
        /// <param name="name">Bus name.</param>
        /// <param name="maxSpeed">Bus max speed.</param>
        /// <param name="mileage">Bus mileage.</param>
        public Bus(int capacity, string name, int maxSpeed, int mileage)
            : base(name, maxSpeed, mileage)
        {
            this.Capacity = capacity;
        }

        /// <summary>
        /// Gets the seat capacity.
        /// </summary>
        public int Capacity { get; private set; }

        /// <summary>
        /// Bus information.
        /// </summary>
        public override void GetVehicleInformation()
        {
            Console.WriteLine($"Name: {this.Name}, MaxSpeed: {this.MaxSpeed}, Mileage: {this.Mileage}, Capacity: {this.Capacity}");
        }
    }
}
