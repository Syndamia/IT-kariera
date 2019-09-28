using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Means_of_travel {
    class Program {
        static void Main(string[] args) {
            Dictionary<string, IVehicle> myVehicles = new Dictionary<string, IVehicle>();
            for (int i = 0; i < 2; i++) {
                var info = Console.ReadLine().Split(' ').ToArray();

                if (info[0] == "Car") {
                    myVehicles.Add("Car", new Car(double.Parse(info[2]), double.Parse(info[1])));
                }
                else {
                    myVehicles.Add("Truck", new Truck(double.Parse(info[2]), double.Parse(info[1])));
                }
            }

            for (int i = int.Parse(Console.ReadLine()); i > 0; i--) {
                var info = Console.ReadLine().Split(' ').ToArray();

                switch (info[0]) {
                    case "Drive":
                        Console.WriteLine(myVehicles[info[1]].Drive(double.Parse(info[2])));
                        break;
                    case "Refuel":
                        myVehicles[info[1]].Refuel(double.Parse(info[2]));
                        break;
                }
            }

            foreach (var veh in myVehicles.Values) {
                Console.WriteLine(veh);
            }
        }
    }
}

