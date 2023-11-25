namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            string wheelCount;
            Console.WriteLine("How Many Wheels you looking for? We'll make it");
            wheelCount = Console.ReadLine();
            var vehicle = VehicleFactory.GetVehicle(wheelCount);
            vehicle.Drive();
        }
    }
}
