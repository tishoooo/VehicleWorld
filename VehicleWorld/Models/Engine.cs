namespace VehicleWorld
{
    /// <summary>
    /// Engine.
    /// </summary>
    public class Engine
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Engine"/> class..
        /// </summary>
        /// <param name="type">Type of engine.</param>
        /// <param name="horsePower">Hors power integer.</param>
        public Engine(EngineType type, int horsePower)
        {
            this.EngineType = type;
            this.Horsepower = horsePower;
        }

        /// <summary>
        /// Gets engine type.
        /// </summary>
        public EngineType EngineType { get; private set; }

        /// <summary>
        /// Gets horsePower.
        /// </summary>
        public int Horsepower { get; private set; }
    }
}