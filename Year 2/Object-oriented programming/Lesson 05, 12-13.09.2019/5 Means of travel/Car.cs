using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Means_of_travel {
    class Car : IVehicle {
        public double FuelPerKM { get; private set; }
        public double FuelAmount { get; private set; }

        public Car(double fuelPerKM, double fuelAmount) {
            FuelPerKM = fuelPerKM + 0.9;
            FuelAmount = fuelAmount;
        }

        public string Drive(double distance) {
            if (distance <= FuelAmount / FuelPerKM) {
                FuelAmount -= distance * FuelPerKM;
                return $"Car travelled {distance} km";
            }
            return "Car needs refueling";
        }

        public void Refuel(double amount) => FuelAmount += amount;

        public override string ToString() => $"Car: {FuelAmount:F2}";
    }
}
