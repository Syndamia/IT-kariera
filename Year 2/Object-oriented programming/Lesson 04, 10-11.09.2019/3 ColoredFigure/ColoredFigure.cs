using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ColoredFigure {
    public abstract class ColoredFigure {
        public string Color { get; protected set; }
        public int Size { get; protected set; }

        protected ColoredFigure(string color, int size) {
            this.Color = color;
            this.Size = size;
        }

        public string Show() {
            return $"Color: {this.Color}\nSize: {this.Size}";
        }

        public virtual string GetName() {
            return "ColoredFigure";
        }

        public virtual string GetArea() {
            return $"Area: {-1}";
        }

        public override string ToString() {
            return $"{GetName()}:\n{Show()}\n{GetArea()}";
        }
    }
}
