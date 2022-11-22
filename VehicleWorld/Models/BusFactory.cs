namespace VehicleWorld
{
    /// <summary>
    /// Bus Factory.
    /// </summary>
    public static class BusFactory
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusFactory"/> class..
        /// </summary>
        /// <param name="name">Bus name.</param>
        /// <param name="maxSpeed">Bus max speed.</param>
        /// <param name="mileage">Bus mileage.</param>
        /// <param name="capacity">Bus capacity.</param>
        /// <param name="engine">Engine.</param>
        /// <returns>new Bus.</returns>
        public static Bus Build(string name, int maxSpeed, int mileage, int capacity, Engine engine)
        {
            Bus bus = new Bus(capacity, name, maxSpeed, mileage, engine);
            return bus;
        }
    }
}
