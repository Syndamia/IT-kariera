using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Means_of_travel_2 {
    class Truck : IVehicle {
        public double FuelPerKM { get; private set; }
        public double TankCapacity { get; private set; }
        public double fuelAmount;

        public Truck(double initialFuelAmount, double fuelPerKM, double tankCapacity) {
            this.FuelPerKM = fuelPerKM + 1.6;
            this.FuelAmount = initialFuelAmount;
            this.TankCapacity = tankCapacity;
        }

        public string Drive(double distance) {
            if (distance <= FuelAmount / FuelPerKM) {
                FuelAmount -= distance * FuelPerKM;
                return $"Truck travelled {distance} km";
            }
            return "Truck needs refueling";
        }

        public void Refuel(double amount) => this.FuelAmount += 0.95 * amount;

        public override string ToString() => $"Truck: {FuelAmount:F2}";

        public double FuelAmount {
            get { return this.fuelAmount; }
            set {
                if (value < 0) {
                    throw new ArgumentException("Fuel must be a positive number");
                }
                this.fuelAmount = value;
            }
        }
    }
}
