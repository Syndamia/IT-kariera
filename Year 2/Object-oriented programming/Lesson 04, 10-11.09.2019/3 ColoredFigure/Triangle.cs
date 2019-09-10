using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ColoredFigure {
    public class Triangle : ColoredFigure {
        public Triangle(string color, int size) : base(color, size) { }

        public override string GetName() {
            return "Triangle";
        }

        public override string GetArea() {
            return $"Area: {(this.Size * this.Size * Math.Sqrt(3) / 4):F2}";
        }
    }
}
