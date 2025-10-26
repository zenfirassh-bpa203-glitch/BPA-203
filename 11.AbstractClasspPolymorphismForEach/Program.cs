using System.ComponentModel.DataAnnotations;



namespace _11_AbstractClassPolymorphismForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1. 3 Car obyekti yaradın
            var car1 = new Car("Mercedes", "E200", 2023, "90-AA-123", 4, 500, true, 220);
            var car2 = new Car("BMW", "320i", 2022, "10-BB-456", 4, 480, true, 235);
            var car3 = new Car("Toyota", "Camry", 2021, "77-CC-789", 4, 524, true, 210);

            // 2. 2 Motorcycle obyekti yaradın
            var moto1 = new Motorcycle("Yamaha", "R1", 2023, "50-R1-001", 998, false, 299, "Sport");
            var moto2 = new Motorcycle("Harley-Davidson", "Street 750", 2022, "60-HD-002", 1868, true, 180, "Cruiser");

            // 3. 2 Truck obyekti yaradın
            var truck1 = new Truck("MAN", "TGX", 2020, "90-MAN-001", 18, 3, 12, 120);
            var truck2 = new Truck("Volvo", "FH16", 2021, "80-VOL-002", 25, 4, 18, 110);

            Vehicle[] allVehicles = new Vehicle[] { car1, car2, car3, moto1, moto2, truck1, truck2 };

            Console.WriteLine("Her bir obyektin məlumatlarını gösterin");
            //4.Hər bir obyektin məlumatlarını göstərin və yanacaq xərcl
            foreach (var vehicle in allVehicles)
            {
                vehicle.ShowBasicInfo();
                Console.WriteLine(vehicle.GetVehicleInfo());

                double fuelCost = 0;
                if (vehicle is Car car) fuelCost = car.CalculateFuelCost(500);          // Avtomobillər üçün 500 km
                else if (vehicle is Motorcycle moto) fuelCost = moto.CalculateFuelCost(300); // Motosikletlər üçün 300 km
                else if (vehicle is Truck truck) fuelCost = truck.CalculateFuelCost(800);     // Yük maşınları üçün 800 km

                Console.WriteLine($"Yanacaq xerci: {fuelCost:F2} AZN\n");
            }
            Console.WriteLine("Truck yuk elave etmek");
            //5.Truck-a yük əlavə edin
            truck1.LoadCargo(5);
            Console.WriteLine($"Yeni yanacaq xerci (800 km): {truck1.CalculateFuelCost(800):F2} AZN\n");

            Console.WriteLine("Statistika");
            //6.Statistika göstərin
            int totalVehicles = allVehicles.Length;
            double avgMaxSpeed = 0;
            double maxFuelCost = 0;
            Vehicle mostExpensiveFuel = null;

            foreach (Vehicle v in allVehicles)
            {
                avgMaxSpeed += v.MaxSpeed;

                double fuelCost = 0;
                if (v is Car c) fuelCost = c.CalculateFuelCost(500);
                else if (v is Motorcycle m) fuelCost = m.CalculateFuelCost(300);
                else if (v is Truck t) fuelCost = t.CalculateFuelCost(800);

                if (fuelCost > maxFuelCost)
                {
                    maxFuelCost = fuelCost;
                    mostExpensiveFuel = v;
                }
            }
            avgMaxSpeed /= totalVehicles;

            Console.WriteLine($"Ümumi neqliyyat sayı: {totalVehicles}");
            Console.WriteLine($"Orta maksimum süret: {avgMaxSpeed:F2} km/s");
            Console.WriteLine($"En bahalı yanacaq xerci olan neqliyyat: {mostExpensiveFuel.Brand} {mostExpensiveFuel.Model}");

        }
    }
}
