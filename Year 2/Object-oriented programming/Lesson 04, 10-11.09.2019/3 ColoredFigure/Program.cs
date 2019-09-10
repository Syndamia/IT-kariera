using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ColoredFigure {
    class Program {
        static void Main(string[] args) {
            //NOTE: in examples part of the task, the last line, "Area: 7.79", is wrong, it should be 3.90 (checked it with calculator)

            for (int i = int.Parse(Console.ReadLine()); i > 0; i--) {
                var input = Console.ReadLine().Split(' ').ToArray();

                switch (input[0]) {
                    case "Circle":
                        Console.WriteLine(new Circle(input[1], int.Parse(input[2])));
                        break;
                    case "Square":
                        Console.WriteLine(new Square(input[1], int.Parse(input[2])));
                        break;
                    case "Triangle":
                        Console.WriteLine(new Triangle(input[1], int.Parse(input[2])));
                        break;
                }
            }
        }
    }
}
