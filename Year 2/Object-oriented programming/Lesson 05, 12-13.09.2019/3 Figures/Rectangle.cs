using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Figures {
    public class Rectangle : Shape {
        public double Width { get; private set; }
        public double Height { get; private set; }

        public Rectangle(double width, double height) {
            this.Width = width;
            this.Height = height;
        }

        public override double calculateArea() => Width * Height;

        public override double calculatePerimeter() => 2 * (Width + Height);

        public sealed override string Draw() {

            return base.Draw() + "Rectangle";
        }
    }
}
