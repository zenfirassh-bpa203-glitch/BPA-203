using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_AbstractClassPolymorphismForEach
{
    public class Motorcycle : Vehicle
    {
        public int EngineCapacity { get; set; }
        public bool HasSidecar { get; set; }
        public int MaxSpeed { get; set; }
        public string Type { get; set; }

        public Motorcycle(string brand, string model, int year, string plateNumber,
                          int engineCapacity, bool hasSidecar, int maxSpeed, string type)
            : base(brand, model, year, plateNumber)
        {
            this.EngineCapacity = engineCapacity;
            this.HasSidecar = hasSidecar;
            this.MaxSpeed = maxSpeed;
            this.Type = type;
        }
        public override string GetVehicleInfo()
        {
            return $"{Brand} {Model} ({Year}) - {Type}, {MaxSpeed} km/s";

        }
        public void ShowMotorcycleInfo()
        {
            ShowBasicInfo();
            Console.WriteLine($"Mühərrik: {EngineCapacity}cc, Sidecar: {HasSidecar}, Növ: {Type}, Max sürət: {MaxSpeed} km/s");
        }

        public double CalculateFuelCost(double distance)
        {
            double cost = (distance / 100) * 4 * 1.50;
            return cost;
        }
    }
}
