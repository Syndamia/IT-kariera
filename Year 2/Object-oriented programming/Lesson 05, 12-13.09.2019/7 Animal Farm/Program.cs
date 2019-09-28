using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Animal_Farm {
    class Program {
        static void Main(string[] args) {
            while (true) {
                string[] input = Console.ReadLine().Split().ToArray();
                if (input.First() == "End") break;

                IAnimal currAnimal = null;
                switch (input[0]) {
                    case "Cat": currAnimal = new Cat(input[0], input[1], double.Parse(input[2]), input[3], input[4]); break;
                    case "Tiger": currAnimal = new Tiger(input[0], input[1], double.Parse(input[2]), input[3]); break;
                    case "Zebra": currAnimal = new Zebra(input[0], input[1], double.Parse(input[2]), input[3]); break;
                    case "Mouse": currAnimal = new Mouse(input[0], input[1], double.Parse(input[2]), input[3]); break;
                }

                string[] food = Console.ReadLine().Split().ToArray();

                IFood avalableFood = null;
                switch (food[0]) {
                    case "Vegetable": avalableFood = new Vegetable(int.Parse(food[1])); break;
                    case "Meat": avalableFood = new Meat(int.Parse(food[1])); break;
                }

                Console.WriteLine(currAnimal.makeSound());

                try {
                    currAnimal.eat(avalableFood);
                } catch (ArgumentException e) {
                    Console.WriteLine(e.Message);
                }

                Console.WriteLine(currAnimal.ToString());
            }
        }

        /* A very extensive test:

Cat Gray 1.1 Home Persian
Vegetable 4
Cat Gray 1.1 Home Persian
Meat 8
Tiger Typcho 167.7 Asia
Vegetable 1
Tiger Typcho 167.7 Asia
Meat 4
Zebra Doncho 500 Africa
Vegetable 150
Zebra Doncho 500 Africa
Meat 30
Mouse Jerry 0.5 Anywhere
Vegetable 1
Mouse Jerry 0.5 Anywhere
Meat 2
End
         */
    }
}
