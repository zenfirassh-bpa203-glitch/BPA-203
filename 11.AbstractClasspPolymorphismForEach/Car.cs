using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _11_AbstractClassPolymorphismForEach
{
    public class Car : Vehicle
    {
        public int DoorCount { get; set; }
        public int runkCapacity { get; set; }
        public bool IsAutomatic { get; set; }
        public int MaxSpeed { get; set; }


        public Car(string brand, string model, int year, string plateNumber,
            int doorCount, int runkCapacity, bool isAutomatic, int maxSpeed)
            : base(brand, model, year, plateNumber)
        {
            this.DoorCount = doorCount;
            this.runkCapacity = runkCapacity;
            this.IsAutomatic = isAutomatic;
            this.MaxSpeed = maxSpeed;
        }
        public override string GetVehicleInfo()
        {
            return $"{Brand} {Model} ({Year}) - {MaxSpeed} km/s";
        }
        public void ShowCarInfo()
        {
            Console.WriteLine($"Door Count: {DoorCount}, Runk Capacity: {runkCapacity}L, Is Automatic: {IsAutomatic}, Max Speed: {MaxSpeed} km/s");
        }
        public double CalculateFuelCost(double distance)
        {
            double fuelcost = (distance / 100) * 8 * 1.50;
            return fuelcost;
        }

    }
}

