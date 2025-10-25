using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _11_AbstractClassPolymorphismForEach
{
    public abstract class Vehicle
    {
        public string Brand { get ; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string PlateNumber { get; set; }
        public double FuelLevel { get; set; }
        public double MaxSpeed { get; internal set; }

        protected Vehicle(string brand, string model, int year, string plateNumber, double fuelLevel)
        {
            this.Brand = brand;
            this.Model = model;
            this.Year = year;
            this.PlateNumber = plateNumber;
            this.FuelLevel = 100.0;

            
        }

        protected Vehicle(string brand, string model, int year, string plateNumber)
        {
            Brand = brand;
            Model = model;
            Year = year;
            PlateNumber = plateNumber;
        }

        public abstract string GetVehicleInfo();
        public virtual void ShowBasicInfo()
        {
                       Console.WriteLine($"Brand: {Brand}, Model: {Model}, Year: {Year}, Plate Number: {PlateNumber}, Fuel Level: {FuelLevel}%");
        }


    }
}
