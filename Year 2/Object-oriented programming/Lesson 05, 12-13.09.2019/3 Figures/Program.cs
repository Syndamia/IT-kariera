using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Figures {
    class Program {
        static void Main(string[] args) {
            Shape myShape = new Circle(5);
            PrintEverythingOfShape(myShape);

            myShape = new Rectangle(8, 13);
            PrintEverythingOfShape(myShape);
        }

        private static void PrintEverythingOfShape(Shape myShape) {
            Console.WriteLine("Area: " + myShape.calculateArea());
            Console.WriteLine("Perimeter: " + myShape.calculatePerimeter());
            Console.WriteLine(myShape.Draw());
        }
    }
}
