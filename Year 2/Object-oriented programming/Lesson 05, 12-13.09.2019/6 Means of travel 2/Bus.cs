using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Means_of_travel_2 {
    class Bus : IVehicle {
        public double FuelPerKM { get; private set; }
        private double fuelAmount;
        public double TankCapacity { get; private set; }

        public Bus(double initialFuelAmount, double fuelPerKM, double tankCapacity) {
            this.FuelPerKM = fuelPerKM + 1.4;
            this.FuelAmount = initialFuelAmount;
            this.TankCapacity = tankCapacity;
        }

        public string DriveEmpty(double distance) {
            this.FuelPerKM -= 1.4;
            var toReturn = this.Drive(distance);
            this.FuelPerKM += 1.4;
            return toReturn;
        }

        public string Drive(double distance) {
            if (distance <= FuelAmount / FuelPerKM) {
                FuelAmount -= distance * FuelPerKM;
                return $"Bus travelled {distance} km";
            }
            return "Bus needs refueling";
        }

        public void Refuel(double amount) {
            if (FuelAmount + amount > TankCapacity) {
                throw new ArgumentException("Cannot fit fuel in tank");
            }
            this.FuelAmount += amount;
        }

        public override string ToString() => $"Bus: {FuelAmount:F2}";

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
