using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ColoredFigure {
    public class Circle : ColoredFigure{
        public Circle(string color, int size) : base(color, size) { }

        public override string GetName() {
            return "Circle";
        }

        public override string GetArea() {
            return $"Area: {(Math.PI * this.Size * this.Size):F2}";
        }
    }
}
