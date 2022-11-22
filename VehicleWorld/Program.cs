using VehicleWorld.Models;

namespace VehicleWorld
{
    public class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle("Car", 200, 260);
            Engine busEngine = new Engine(EngineType.Diesel, 150);
            Bus bus = new Bus(10, "Bus", 150, 150, busEngine);
            Bicycle bicycle = new Bicycle("Kroc", 20, 30);
            Engine carEngine = new Engine(EngineType.Electric, 250);
            Car car = new Car("Audi", 150, 180, carEngine);

            car.Drive(9820);
            bus.Drive(9850);
            bicycle.Drive(9970);

            vehicle.GetVehicleInformation();
            bus.GetVehicleInformation();
            bicycle.GetVehicleInformation();
            car.GetVehicleInformation();

            var carFactory = CarFactory.Build("Audi produced by CarFactory", 330, 360, carEngine);
            carFactory.GetVehicleInformation();

            var busFactory = BusFactory.Build("Bus produced by BusFactory", 160, 210, 80, busEngine);
            busFactory.GetVehicleInformation();

            var bicycleFactory = BicycleFactory.Build("Bicycle produced by BicycleFactory", 20, 16);
            bicycleFactory.GetVehicleInformation();
        }
    }
}