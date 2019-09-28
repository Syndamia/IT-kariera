using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Figures {
    public class Circle : Shape {
        public double Radius { get; private set; }

        public Circle(double radius) {
            this.Radius = radius;
        }

        public override double calculateArea() => Math.PI * Radius * Radius;

        public override double calculatePerimeter() => Math.PI * 2 * Radius;

        public sealed override string Draw() {
            return base.Draw() + "Circle";
        }
    }
}
