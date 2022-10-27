namespace VehicleWorld
{
    /// <summary>
    /// Bicycle.
    /// </summary>
    public class Bicycle : Vehicle
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Bicycle"/> class..
        /// </summary>
        /// <param name="name">Bicycle's name.</param>
        /// <param name="maxSpeed">Bicycle's max speed.</param>
        /// <param name="mileage">Bicycle's mileage.</param>
        public Bicycle(string name, int maxSpeed, int mileage)
            : base(name, maxSpeed, mileage)
        {
        }
    }
}
