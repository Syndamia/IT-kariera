using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Means_of_travel_2 {
    public interface IVehicle {
        double FuelAmount { get; }
        double TankCapacity { get; }
        double FuelPerKM { get; }

        string Drive(double distance);
        void Refuel(double amount);
    }
}
