using _11_AbstractClassPolymorphismForEach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_AbstractClassPolymorphismForEach
{
    public class Truck : Vehicle
    {
        public double CargoCapacity { get; set; }
        public int AxleCount { get; set; }
        public double CurrentLoad { get; set; }
        public int MaxSpeed { get; set; }

        public Truck(string brand, string model, int year, string plateNumber,
                     double cargoCapacity, int axleCount, double currentLoad, int maxSpeed)
            : base(brand, model, year, plateNumber)
        {
            this.CargoCapacity = cargoCapacity;
            this.AxleCount = axleCount;
            this.CurrentLoad = currentLoad;
            this.MaxSpeed = maxSpeed;
        }

        public override string GetVehicleInfo()
        {
            return $"{Brand} {Model} ({Year}) - {MaxSpeed} km/s, Cari yük: {CurrentLoad} ton";
        }
        public void ShowTruckInfo()
        {
            ShowBasicInfo();
            Console.WriteLine($"Yük tutumu: {CargoCapacity} ton, Cari yük: {CurrentLoad} ton, Ox sayı: {AxleCount}, Max sürət: {MaxSpeed} km/s");
        }

        public void LoadCargo(double weight)
        {
            if (CurrentLoad + weight <= CargoCapacity)
            {
                CurrentLoad += weight;
                Console.WriteLine($"✅ {weight} ton əlavə edildi. Yeni yük: {CurrentLoad} ton.");
            }
            else
            {
                Console.WriteLine($"❌ Yük əlavə edilə bilmədi. Tutum aşılır ({CargoCapacity} ton).");
            }
        }

        public double CalculateFuelCost(double distance)
        {
            double cost = (distance / 100) * (25 + CurrentLoad * 2) * 1.80;
            return cost;
        }
    }
}

