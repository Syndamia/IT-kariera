using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2_Cars {
    public class Seat : ICar {
        public string Model { get; set; }
        public string Color { get; set; }

        public Seat(string model, string color) {
            this.Model = model;
            this.Color = color;
        }

        public string Start() {
            return "Engine start";
        }

        public string Stop() {
            return "Breaaak!";
        }

        public override string ToString() {
            return $"{this.Model} Seat {this.Color}\n{Start()}\n{Stop()}";
        }
    }
}
