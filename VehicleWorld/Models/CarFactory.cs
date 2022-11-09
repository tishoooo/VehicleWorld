namespace VehicleWorld
{
    /// <summary>
    /// Car Factory.
    /// </summary>
    public static class CarFactory
    {
        /// <summary>
        /// Produce new car.
        /// </summary>
        /// <param name="name">Vehicle's name.</param>
        /// <param name="maxSpeed">Vehicle's max speed.</param>
        /// <param name="mileage">Vehicle's mileage.</param>
        /// <returns>New car.</returns>
        public static Car Build(string name, int maxSpeed, int mileage)
        {
            Car car = new Car(name, maxSpeed, mileage);
            return car;
        }
    }
}
