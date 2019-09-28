using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Means_of_travel {
    public interface IVehicle {
        double FuelAmount { get; }
        double FuelPerKM { get; }

        string Drive(double distance);
        void Refuel(double amount);
    }
}
