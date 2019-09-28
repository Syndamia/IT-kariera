using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Means_of_travel_2 {
    class Program {
        static void Main(string[] args) {
            Dictionary<string, IVehicle> myVehicles = new Dictionary<string, IVehicle>();
            for (int i = 0; i < 3; i++) {
                var info = Console.ReadLine().Split(' ').ToArray();


                switch (info[0]) {
                    case "Car":
                        myVehicles.Add("Car", new Car(double.Parse(info[1]), double.Parse(info[2]), double.Parse(info[3])));
                        break;
                    case "Truck":
                        myVehicles.Add("Truck", new Truck(double.Parse(info[1]), double.Parse(info[2]), double.Parse(info[3])));
                        break;
                    case "Bus":
                        myVehicles.Add("Bus", new Bus(double.Parse(info[1]), double.Parse(info[2]), double.Parse(info[3])));
                        break;
                }
            }

            for (int i = int.Parse(Console.ReadLine()); i > 0; i--) {
                var info = Console.ReadLine().Split(' ').ToArray();

                try {
                    switch (info[0]) {
                        case "Drive":
                            Console.WriteLine(myVehicles[info[1]].Drive(double.Parse(info[2])));
                            break;
                        case "DriveEmpty":
                            Console.WriteLine(((Bus)myVehicles["Bus"]).DriveEmpty(double.Parse(info[2])));
                            break;
                        case "Refuel":
                            myVehicles[info[1]].Refuel(double.Parse(info[2]));
                            break;
                    }
                } catch (ArgumentException e) {
                    Console.WriteLine(e.Message);
                }
            }

            foreach (var veh in myVehicles.Values) {
                Console.WriteLine(veh);
            }
        }
    }
}

