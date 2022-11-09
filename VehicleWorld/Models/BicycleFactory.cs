namespace VehicleWorld.Models
{
    /// <summary>
    /// Bicycle Factory.
    /// </summary>
    public static class BicycleFactory
    {
        /// <summary>
        /// Produce new bicycle.
        /// </summary>
        /// <param name="name">Vehicle's name.</param>
        /// <param name="maxSpeed">Vehicle's max speed.</param>
        /// <param name="mileage">Vehicle's mileage.</param>
        /// <returns>new Bicycle</returns>
        public static Bicycle Build(string name, int maxSpeed, int mileage)
        {
            Bicycle bicycle = new Bicycle(name, maxSpeed, mileage);
            return bicycle;
        }
    }
}
