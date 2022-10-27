namespace VehicleWorld
{
    public class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle("Car", 200, 260);
            Bus bus = new Bus(10, "Audi", 150, 150);
            Bicycle bicycle = new Bicycle("Kros", 20, 30);
            Car car = new Car("Audi", 150, 180);

            vehicle.GetVehicleInformation();
            bus.GetVehicleInformation();
            bicycle.GetVehicleInformation();
            car.GetVehicleInformation();
        }
    }
}