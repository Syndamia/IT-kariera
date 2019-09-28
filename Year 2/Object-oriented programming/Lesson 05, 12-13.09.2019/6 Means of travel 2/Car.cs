using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Means_of_travel_2 {
    class Car : IVehicle {
        public double FuelPerKM { get; private set; }
        private double fuelAmount;
        public double TankCapacity { get; private set; }

        public Car(double initialFuelAmount, double fuelPerKM, double tankCapacity) {
            this.FuelPerKM = fuelPerKM + 0.9;
            this.FuelAmount = initialFuelAmount;
            this.TankCapacity = tankCapacity;
        }

        public string Drive(double distance) {
            if (distance <= FuelAmount / FuelPerKM) {
                FuelAmount -= distance * FuelPerKM;
                return $"Car travelled {distance} km";
            }
            return "Car needs refueling";
        }

        public void Refuel(double amount) {
            if (FuelAmount + amount > TankCapacity) {
                throw new ArgumentException("Cannot fit fuel in tank");
            }
            this.FuelAmount += amount;
        }

        public override string ToString() => $"Car: {FuelAmount:F2}";

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
