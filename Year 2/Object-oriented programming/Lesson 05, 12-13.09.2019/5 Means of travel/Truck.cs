using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Means_of_travel {
    class Truck : IVehicle {
        public double FuelPerKM { get; private set; }
        public double FuelAmount { get; private set; }

        public Truck(double fuelPerKM, double fuelAmount) {
            FuelPerKM = fuelPerKM + 1.6;
            FuelAmount = fuelAmount;
        }

        public string Drive(double distance) {
            if (distance <= FuelAmount / FuelPerKM) {
                FuelAmount -= distance * FuelPerKM;
                return $"Truck travelled {distance} km";
            }
            return "Truck needs refueling";
        }

        public void Refuel(double amount) => FuelAmount += 0.95 * amount;

        public override string ToString() => $"Truck: {FuelAmount:F2}";
    }
}
