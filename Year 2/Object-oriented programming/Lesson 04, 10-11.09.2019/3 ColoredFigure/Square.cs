using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ColoredFigure {
    public class Square : ColoredFigure{
        public Square(string color, int size) : base(color, size) { }

        public override string GetName() {
            return "Square";
        }

        public override string GetArea() {
            return $"Area: {(this.Size * this.Size):F2}";
        }
    }
}
